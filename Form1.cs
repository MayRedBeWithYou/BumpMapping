using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2
{
    public enum States
    {
        None,
        Selecting,
        AddingPolygon,
        Removing,
        SelectingFigure,
        AddingOnEdge,
        Animating
    }

    public enum Filling
    {
        None,
        Color,
        Texture,
        Bump
    }

    public partial class Form1 : Form
    {
        private States prevState = States.Selecting;

        private List<Vertex> vertices = new List<Vertex>();

        private List<Edge> edges = new List<Edge>();

        private List<Polygon> polygons = new List<Polygon>();

        private List<Polygon> randomPolygons = new List<Polygon>();

        private List<(Polygon, Polygon)> inters = new List<(Polygon, Polygon)>();

        private bool isLightOn = false;

        private Point MousePos;

        private Vertex previousVertex;

        private Vertex selectedVertex;

        private Edge selectedEdge;

        private Polygon newPolygon;

        private Polygon selectedPolygon;

        private Timer movementTimer = new Timer();

        private int speed = 100;

        private int maxTick = 500;

        private int tick = 0;

        private Random rng = new Random();

        private double Kd = 0.5;

        private double Ks = 0.5;

        private Bitmap texture;

        private Bitmap cleanTexture;

        private Filling filling = Filling.Color;

        private Bitmap cleanBumpMap;

        private Bitmap bumpMap;

        private Color lightColor = Color.White;

        private Vector3 lightColorVector = new Vector3(1, 1, 1);

        private float height = 0.5f;

        private Point lightPos;

        private readonly Vector3 V = new Vector3(0, 0, 1);

        private States State { get; set; } = States.Selecting;

        private Vertex SelectedVertex
        {
            get => selectedVertex;
            set
            {
                selectedVertex = value;
                RefreshCanvas();
            }
        }

        private Edge SelectedEdge
        {
            get => selectedEdge;
            set
            {
                selectedEdge = value;
                RefreshCanvas();
            }
        }

        private Polygon SelectedPolygon
        {
            get => selectedPolygon;
            set
            {
                selectedPolygon = value;
                RefreshCanvas();
            }
        }

        public Form1()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(BitmapCanvas.Width, BitmapCanvas.Height);
            BitmapCanvas.Image = bitmap;
            ColorPictureBox.Image = new Bitmap(ColorPictureBox.Width, ColorPictureBox.Height);

            texture = new Bitmap(BitmapCanvas.Width, BitmapCanvas.Height);
            cleanTexture = new Bitmap(Zadanie2.Properties.Resources.texture);
            using (Graphics g = Graphics.FromImage(texture))
            {
                TextureBrush b = new TextureBrush(cleanTexture, System.Drawing.Drawing2D.WrapMode.Tile);
                g.FillRectangle(b, 0, 0, BitmapCanvas.Width, BitmapCanvas.Height);
            }
            TextureFileName.Text = "texture.jpg";

            bumpMap = new Bitmap(BitmapCanvas.Width, BitmapCanvas.Height);
            cleanBumpMap = new Bitmap(Zadanie2.Properties.Resources.map);
            using (Graphics g = Graphics.FromImage(bumpMap))
            {
                TextureBrush b = new TextureBrush(cleanBumpMap, System.Drawing.Drawing2D.WrapMode.Tile);
                g.FillRectangle(b, 0, 0, BitmapCanvas.Width, BitmapCanvas.Height);
            }
            BumpMapName.Text = "map.jpg";

            using (Graphics g = Graphics.FromImage(ColorPictureBox.Image))
            {
                g.Clear(lightColor);
            }
            ColorPictureBox.Refresh();

            HeightValue.Text = height.ToString();

            lightPos = new Point(BitmapCanvas.Width / 2, BitmapCanvas.Height / 2);

            movementTimer.Interval = 1600 / speed;
            movementTimer.Tick += MovePolygons;

            RefreshCanvas();
        }

        private void UnselectAll()
        {
            SelectedEdge = null;
            SelectedVertex = null;
            SelectedPolygon = null;
            RefreshCanvas();
        }

        private Vertex AddNewVertex(Point p)
        {
            Vertex vertex = new Vertex();
            vertices.Add(vertex);
            if (newPolygon == null)
            {
                newPolygon = new Polygon();
                polygons.Add(newPolygon);
            }
            vertex.Polygon = newPolygon;
            newPolygon.Vertices.Add(vertex);
            SelectedVertex = vertex;
            vertex.Position = new Point(p.X - vertex.Size / 2, p.Y - vertex.Size / 2);
            return vertex;
        }

        private Edge AddNewEdge(Vertex from, Vertex to)
        {
            if (from.Edges.Count < 2 && to.Edges.Count < 2)
            {
                if (from.Edges.Count != 0)
                {
                    if (from.Edges[0].From == to || from.Edges[0].To == to)
                    {
                        return null;
                    }
                }
                Edge newEdge = new Edge(from, to);
                from.Edges.Add(newEdge);
                to.Edges.Add(newEdge);
                edges.Add(newEdge);
                Algorithms.CalculateEdge(newEdge);
                return newEdge;
            }
            return null;
        }

        private void RemoveEdge(Edge e)
        {
            edges.Remove(e);
            e.From.Edges.Remove(e);
            e.To.Edges.Remove(e);
            e.Polygon.Edges.Remove(e);
        }

        private void DeletePolygon(Polygon poly)
        {
            while (poly.Edges.Count != 0)
            {
                RemoveEdge(poly.Edges[0]);
            }

            while (poly.Vertices.Count != 0)
            {
                if (poly.Vertices[0] == SelectedVertex) SelectedVertex = null;
                vertices.Remove(poly.Vertices[0]);
                poly.Vertices.RemoveAt(0);
            }
            polygons.Remove(poly);
            RefreshCanvas();
        }

        private void HighlightVertex(Vertex v, Bitmap bitmap)
        {
            for (int i = v.Position.X - v.Size / 2; i < v.Position.X + v.Size / 2; i++)
            {
                for (int j = v.Position.Y - v.Size / 2; j < v.Position.Y + v.Size / 2; j++)
                {
                    if (i >= 0 && j >= 0 && i < bitmap.Width && j < bitmap.Height)
                        bitmap.SetPixel(i, j, Color.Orange);
                }
            }
        }

        private void HighlightEdge(Edge e, Bitmap bitmap)
        {
            foreach (Point p in e.Points)
            {
                if (p.X >= 0 && p.Y >= 0 && p.X < bitmap.Width && p.Y < bitmap.Height)
                    bitmap.SetPixel(p.X, p.Y, Color.Orange);
            }
        }

        private void HighlightPolygon(Polygon poly, Bitmap bitmap)
        {
            foreach (Edge e in poly.Edges)
            {
                foreach (Point p in e.Points)
                {
                    if (p.X >= 0 && p.Y >= 0 && p.X < bitmap.Width && p.Y < bitmap.Height)
                        bitmap.SetPixel(p.X, p.Y, Color.Orange);
                }
            }
            foreach (Vertex v in poly.Vertices)
            {
                HighlightVertex(v, bitmap);
            }
        }

        private void RefreshCanvas()
        {
            Bitmap bitmap = new Bitmap(BitmapCanvas.Width, BitmapCanvas.Height);

            foreach (Polygon poly in polygons)
            {
                if (State != States.Animating)
                {
                    foreach (Vertex v in poly.Vertices)
                    {
                        for (int i = v.Position.X - v.Size / 2; i < v.Position.X + v.Size / 2; i++)
                        {
                            for (int j = v.Position.Y - v.Size / 2; j < v.Position.Y + v.Size / 2; j++)
                            {
                                if (i >= 0 && j >= 0 && i < bitmap.Width && j < bitmap.Height)
                                    bitmap.SetPixel(i, j, v.Color);
                            }
                        }
                    }
                }
                foreach (Edge e in poly.Edges)
                {
                    foreach (Point p in e.Points)
                    {
                        if (p.X >= 0 && p.Y >= 0 && p.X < bitmap.Width && p.Y < bitmap.Height)
                            bitmap.SetPixel(p.X, p.Y, e.Color);
                    }
                }
            }

            foreach (Polygon poly in randomPolygons)
            {
                foreach (Edge e in poly.Edges)
                {
                    foreach (Point p in e.Points)
                    {
                        if (p.X >= 0 && p.Y >= 0 && p.X < bitmap.Width && p.Y < bitmap.Height)
                            bitmap.SetPixel(p.X, p.Y, e.Color);
                    }
                }
            }

            if (State != States.Animating)
            {
                if (SelectedPolygon != null)
                {
                    HighlightPolygon(SelectedPolygon, bitmap);
                }
                else if (SelectedVertex != null)
                {
                    HighlightVertex(SelectedVertex, bitmap);
                }
                else if (SelectedEdge != null)
                {
                    HighlightEdge(SelectedEdge, bitmap);
                }
            }
            else
            {
                foreach ((Polygon poly, Polygon p) in inters)
                {
                    FillIntersection(poly, p, bitmap);
                }
            }

            if (isLightOn)
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    SolidBrush b = new SolidBrush(Color.Yellow);
                    g.FillEllipse(b, lightPos.X - 9, lightPos.Y - 9, 21, 21);
                    g.DrawEllipse(new Pen(new SolidBrush(Color.Black)), lightPos.X - 9, lightPos.Y - 9, 21, 21);
                }
            }

            BitmapCanvas.Image = bitmap;
            BitmapCanvas.Refresh();
        }

        private void CanvasMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && isLightOn)
            {
                lightPos = e.Location;
                RefreshCanvas();
            }

            MouseEventArgs ev = e as MouseEventArgs;
            Point pos = new Point(ev.Location.X, ev.Location.Y);

            Bitmap bitmap = (Bitmap)BitmapCanvas.Image;

            SelectedPolygon = null;
            SelectedVertex = null;
            SelectedEdge = null;

            if (e.Button == MouseButtons.Left)
            {
                switch (State)
                {
                    case States.None:
                        break;

                    case States.Selecting:
                        foreach (Polygon poly in polygons)
                        {
                            foreach (Vertex v in poly.Vertices)
                            {
                                if (Algorithms.Distance(pos, v.Position) <= v.Size / 2)
                                {
                                    SelectedVertex = v;
                                    MousePos = pos;
                                    return;
                                }
                            }
                            foreach (Edge edge in poly.Edges)
                            {
                                foreach (Point p in edge.Points)
                                {
                                    if (Algorithms.Distance(pos, p) < 5)
                                    {
                                        SelectedEdge = edge;
                                        MousePos = pos;
                                        return;
                                    }
                                }
                            }
                        }

                        break;

                    case States.AddingOnEdge:
                        Point closest = Point.Empty;
                        double minDist = double.MaxValue;
                        Edge closestEdge = null;
                        foreach (Polygon poly in polygons)
                        {

                            foreach (Edge edge in poly.Edges)
                            {
                                foreach (Point p in edge.Points)
                                {
                                    double distance = Algorithms.Distance(pos, p);
                                    if (distance < 10)
                                    {
                                        if (distance < minDist)
                                        {
                                            closest = p;
                                            minDist = distance;
                                            closestEdge = edge;
                                        }
                                    }
                                }
                            }
                        }
                        if (closestEdge != null)
                        {
                            SelectedPolygon = null;
                            SelectedVertex = closestEdge.From;
                            Polygon poly = closestEdge.Polygon;
                            int index = poly.Edges.IndexOf(closestEdge);
                            closest = new Point(closest.X + 5, closest.Y + 5);
                            RemoveEdge(closestEdge);
                            Vertex v = new Vertex(closest.X, closest.Y);
                            vertices.Add(v);
                            v.Color = poly.Color;
                            v.Polygon = poly;
                            poly.Vertices.Insert(poly.Vertices.IndexOf(closestEdge.To), v);

                            Edge e1 = AddNewEdge(v, closestEdge.To);
                            e1.Color = poly.Color;
                            Algorithms.CalculateEdge(e1);

                            Edge e2 = AddNewEdge(closestEdge.From, v);
                            e2.Color = poly.Color;
                            Algorithms.CalculateEdge(e2);
                            poly.Edges.Insert(index, e1);
                            poly.Edges.Insert(index, e2);
                            e1.Polygon = poly;
                            e2.Polygon = poly;
                            SelectedEdge = null;
                            SelectedVertex = v;
                            MousePos = e.Location;
                            RefreshCanvas();
                            return;
                        }
                        break;

                    case States.SelectingFigure:
                        foreach (Polygon poly in polygons)
                        {
                            foreach (Vertex v in poly.Vertices)
                            {
                                if (Algorithms.Distance(pos, v.Position) <= v.Size / 2)
                                {
                                    SelectedPolygon = v.Polygon;
                                    MousePos = pos;

                                    return;
                                }
                            }
                            foreach (Edge edge in poly.Edges)
                            {
                                foreach (Point p in edge.Points)
                                {
                                    if (Algorithms.Distance(pos, p) < 10)
                                    {
                                        SelectedPolygon = edge.To.Polygon;
                                        MousePos = pos;

                                        return;
                                    }
                                }
                            }
                        }
                        break;

                    case States.AddingPolygon:
                        SelectedVertex = null;
                        foreach (Vertex v in vertices)
                        {
                            if (Algorithms.Distance(pos, v.Position) < 10)
                            {
                                SelectedPolygon = null;
                                SelectedVertex = v;
                                SelectedEdge = null;
                                MousePos = pos;
                                break;
                            }
                        }
                        if (SelectedVertex != null)
                        {
                            if (SelectedVertex == previousVertex || SelectedVertex.Polygon.isClosed) SelectedVertex = null;
                            else if (SelectedVertex.Edges.Count < 2)
                            {
                                Edge edge = AddNewEdge(previousVertex, SelectedVertex);
                                previousVertex.Polygon.Edges.Add(edge);
                                edge.Polygon = previousVertex.Polygon;
                                edge.Polygon.isClosed = true;
                                newPolygon = null;
                                previousVertex = null;
                            }
                            RefreshCanvas();
                            return;
                        }
                        Vertex ver = AddNewVertex(pos);
                        if (previousVertex != null)
                        {
                            Edge edge = AddNewEdge(previousVertex, ver);
                            edge.Polygon = newPolygon;
                            newPolygon.Edges.Add(edge);
                        }
                        previousVertex = ver;
                        MousePos = e.Location;
                        break;

                    case States.Removing:
                        SelectedVertex = null;
                        foreach (Vertex v in vertices)
                        {
                            if (Algorithms.Distance(pos, v.Position) <= v.Size / 2)
                            {
                                SelectedPolygon = null;
                                SelectedVertex = v;
                                SelectedEdge = null;
                                MousePos = pos;
                                break;
                            }
                        }
                        if (SelectedVertex != null)
                        {
                            Polygon poly = SelectedVertex.Polygon;
                            if (poly.Vertices.Count == 3)
                            {
                                DeletePolygon(poly);
                            }
                            else
                            {
                                (Vertex v1, Vertex v2) = SelectedVertex.GetNeighbors();

                                while (SelectedVertex.Edges.Count != 0)
                                {
                                    RemoveEdge(SelectedVertex.Edges[0]);
                                }
                                int index = poly.Edges.IndexOf(v2.Edges[0]);
                                Edge newEdge = AddNewEdge(v1, v2);
                                newEdge.Color = poly.Color;
                                poly.Edges.Insert(index, newEdge);
                                newEdge.Polygon = poly;
                                poly.Vertices.Remove(SelectedVertex);
                                vertices.Remove(SelectedVertex);
                                SelectedVertex = null;
                            }
                        }
                        break;
                }
            }

            RefreshCanvas();
        }

        private void CanvasMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && isLightOn)
            {
                lightPos = e.Location;
                RefreshCanvas();
            }

            if (e.Button == MouseButtons.Left)
            {
                int diffX = MousePos.X - e.X;
                int diffY = MousePos.Y - e.Y;

                switch (State)
                {
                    case States.None:
                        break;

                    case States.Selecting:
                    case States.AddingOnEdge:
                    case States.AddingPolygon:
                        if (SelectedEdge != null)
                        {
                            SelectedEdge.From.Position.X -= diffX;
                            SelectedEdge.To.Position.X -= diffX;
                            SelectedEdge.From.Position.Y -= diffY;
                            SelectedEdge.To.Position.Y -= diffY;
                            foreach (Edge edge in SelectedEdge.From.Edges)
                            {
                                Algorithms.CalculateEdge(edge);
                            }
                            foreach (Edge edge in SelectedEdge.To.Edges)
                            {
                                Algorithms.CalculateEdge(edge);
                            }
                            MousePos = e.Location;
                            RefreshCanvas();
                        }
                        else if (SelectedVertex != null)
                        {
                            Point p = BitmapCanvas.PointToScreen(Point.Empty);
                            SelectedVertex.Position.X -= diffX;
                            SelectedVertex.Position.Y -= diffY;
                            foreach (Edge edge in SelectedVertex.Edges)
                            {
                                Algorithms.CalculateEdge(edge);
                            }
                            MousePos = e.Location;
                            RefreshCanvas();
                        }
                        break;
                    case States.Removing:
                        break;

                    case States.SelectingFigure:
                        if (SelectedPolygon != null)
                        {
                            foreach (Vertex v in SelectedPolygon.Vertices)
                            {
                                v.Position.X -= diffX;
                                v.Position.Y -= diffY;
                            }
                            foreach (Edge edge in SelectedPolygon.Edges)
                            {
                                Algorithms.CalculateEdge(edge);
                            }
                            MousePos = e.Location;
                        }
                        RefreshCanvas();
                        break;
                }
            }
        }

        private void SelectVertexRadioChanged(object sender, EventArgs e)
        {
            if (SelectVertexRadioButton.Checked)
            {
                State = States.Selecting;
            }
        }

        private void AddPolygonRadioChanged(object sender, EventArgs e)
        {
            if (AddPolygonRadioButton.Checked)
            {
                State = States.AddingPolygon;
            }
            else if (newPolygon != null && !newPolygon.isClosed)
            {
                DeletePolygon(newPolygon);
                SelectedVertex = null;
                previousVertex = null;
                newPolygon = null;
            }
        }

        private void RemoveVertexRadioChanged(object sender, EventArgs e)
        {
            if (RemoveVertexRadioButton.Checked)
            {
                State = States.Removing;
            }
        }

        private void SelectFigureRadioChanged(object sender, EventArgs e)
        {
            if (SelectFigureRadioButton.Checked)
            {
                State = States.SelectingFigure;
            }
        }

        private void AddVertexRadioChanged(object sender, EventArgs e)
        {
            if (AddVertexRadioButton.Checked)
            {
                State = States.AddingOnEdge;
            }
        }

        private void AnimateCheckBoxChanged(object sender, EventArgs e)
        {
            if (AnimateCheckBox.Checked)
            {
                SelectedEdge = null;
                SelectedPolygon = null;
                SelectedVertex = null;
                movementTimer.Start();
                if (randomPolygons.Count == 0) tick = maxTick;
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.MaximizeBox = false;
                prevState = State;
                State = States.Animating;
                PolygonToolsBox.Enabled = false;
                PolygonSpeedSlider.Enabled = false;
            }
            else
            {
                movementTimer.Stop();
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.MaximizeBox = true;
                State = prevState;
                PolygonToolsBox.Enabled = true;
                PolygonSpeedSlider.Enabled = true;
                //RefreshCanvas();
            }
        }

        private bool IsOutsideView(Polygon poly)
        {
            foreach (Vertex v in poly.Vertices)
            {
                if (v.Position.X > 0) return false;
            }
            return true;
        }

        private void MovePolygons(object sender, EventArgs e)
        {
            if (tick == maxTick / 2)
            {
                Debug.WriteLine(randomPolygons.RemoveAll(poly => IsOutsideView(poly)));
            }
            if (tick == maxTick)
            {
                tick = 0;
                randomPolygons.RemoveAll(poly => IsOutsideView(poly));
                randomPolygons.Add(Algorithms.GenerateRandomPolygon(rng.Next(4, 10), BitmapCanvas.Height * 2 / 5, BitmapCanvas.Width + 300));
            }
            if (randomPolygons.Count == 0) return;
            inters.Clear();
            Parallel.ForEach(randomPolygons, p =>
            {
                foreach (Vertex v in p.Vertices)
                {
                    v.Position.X -= 1;
                }
                foreach (Edge edge in p.Edges)
                {
                    Algorithms.CalculateEdge(edge);
                }

                Parallel.ForEach(polygons, poly =>
                {
                    Point[] points = Algorithms.GetIntersectedPolygon(poly, p);
                    if (points.Length != 0)
                    {
                        Polygon inter = new Polygon();
                        inter.Vertices.Add(new Vertex(points[0].X, points[0].Y));
                        for (int i = 1; i < points.Length; i++)
                        {
                            Vertex v = new Vertex(points[i].X, points[i].Y);
                            Edge edge = new Edge(inter.Vertices[inter.Vertices.Count - 1], v);
                            inter.Vertices.Add(v);
                            inter.Edges.Add(edge);
                            edge.Polygon = inter;
                        }
                        inter.Edges.Add(new Edge(inter.Vertices[inter.Vertices.Count - 1], inter.Vertices[0]));
                        inter.Edges[inter.Edges.Count - 1].Polygon = inter;
                        inters.Add((inter, p));
                    }
                });
            });
            tick++;
            RefreshCanvas();
        }

        private void SpeedSliderChanged(object sender, EventArgs e)
        {
            speed = PolygonSpeedSlider.Value;
            movementTimer.Interval = 1600 / speed;
        }

        private void ClearRandoms_Click(object sender, EventArgs e)
        {
            randomPolygons.Clear();
            tick = maxTick;
            RefreshCanvas();
        }

        private struct EdgeData
        {
            public Edge edge;
            public int yMax;
            public int yMin;
            public double xMin;
            public double diff;
        }

        private void FillIntersection(Polygon poly, Polygon parent, Bitmap bitmap)
        {
            List<EdgeData>[] EdgeList = new List<EdgeData>[BitmapCanvas.Height];
            for (int i = 0; i < EdgeList.Length; i++)
            {
                EdgeList[i] = new List<EdgeData>();
            }
            foreach (Edge edge in poly.Edges)
            {
                EdgeData data = new EdgeData();
                data.edge = edge;
                data.yMax = Math.Max(edge.From.Position.Y, edge.To.Position.Y);
                data.yMin = Math.Min(edge.From.Position.Y, edge.To.Position.Y);
                data.xMin = Math.Min(edge.From.Position.X, edge.To.Position.X);
                if (edge.To.Position.Y - edge.From.Position.Y == 0)
                {
                    data.diff = 0;
                }
                else
                    data.diff = (edge.To.Position.X - edge.From.Position.X) / (edge.To.Position.Y - edge.From.Position.Y);
                EdgeList[data.yMin].Add(data);
            }

            List<EdgeData> AET = new List<EdgeData>();
            int index = 0;
            int count = poly.Edges.Count;
            while (EdgeList[index].Count == 0) index++;

            while (count != 0)
            {
                AET.AddRange(EdgeList[index]);
                AET.Sort((e1, e2) => (int)(e1.xMin - e2.xMin));
                int x = (int)AET[0].xMin;
                List<Point> intersections = new List<Point>();
                Point prev = Point.Empty;
                Point p = Point.Empty;
                EdgeData prevData = new EdgeData();
                foreach (EdgeData data in AET)
                {
                    p = Algorithms.GetScanlineIntersection(data.edge, index, BitmapCanvas.Width);
                    if (p.IsEmpty) continue;
                    if (p.X == prev.X)
                    {
                        int d1 = prevData.edge.From.Position.Y - prevData.edge.To.Position.Y;
                        int d2 = data.edge.From.Position.Y - data.edge.To.Position.Y;
                        if (d1 * d2 >= 0) continue;
                    }
                    prevData = data;
                    prev = p;
                    intersections.Add(p);
                }
                intersections.Sort((p1, p2) => p1.X - p2.X);

                if (intersections.Count % 2 == 1) intersections.RemoveAt(intersections.Count - 1);

                for (int i = 0; i < intersections.Count; i += 2)
                {
                    Color[] colors = new Color[intersections[i + 1].X - intersections[i].X + 1];
                    switch (filling)
                    {
                        case Filling.Color:
                            Parallel.For(0, intersections[i + 1].X - intersections[i].X + 1, c =>
                            {
                                if (c + intersections[i].X >= 0)
                                {
                                    colors[c] = Algorithms.CalculateColor(parent, new Point(c + intersections[i].X, index));
                                }
                            });
                            break;
                        case Filling.Texture:
                            for (int c = 0; c < intersections[i + 1].X - intersections[i].X + 1; c++)
                            {
                                if (c + intersections[i].X < 0) continue;
                                colors[c] = texture.GetPixel(c + intersections[i].X, index);
                            }
                            break;
                        case Filling.Bump:
                            for (int c = 0; c < intersections[i + 1].X - intersections[i].X + 1; c++)
                            {
                                if (c + intersections[i].X < 0) continue;
                                colors[c] = texture.GetPixel(c + intersections[i].X, index);
                                Color normal = bumpMap.GetPixel(c + intersections[i].X, index);
                                float Nx = (normal.R - 127) / 128f;
                                float Ny = (normal.G - 127) / 128f;
                                float Nz = (normal.B - 127) / 128f;
                                Vector3 N = new Vector3(Nx, Ny, Nz);
                                N = Vector3.Normalize(N);
                                Vector3 L = new Vector3(0, 0, 1);
                                if (isLightOn)
                                {
                                    L = new Vector3((c + intersections[i].X - lightPos.X) / (float)BitmapCanvas.Width, (index - lightPos.Y) / (float)BitmapCanvas.Height, height);
                                    L = Vector3.Normalize(L);
                                }

                                double cosN = 0;
                                cosN = Algorithms.Cos(N, L);
                                float K = Vector3.Dot(N, new Vector3(0, 0, 1));
                                Vector3 Rv = 2 * K * N - L;
                                double cosVR = Algorithms.Cos(V, Rv);
                                float R = (float)(Kd * lightColorVector.X * colors[c].R / 255f * cosN + Ks * lightColorVector.X * colors[c].R / 255f * cosVR);
                                float G = (float)(Kd * lightColorVector.Y * colors[c].G / 255f * cosN + Ks * lightColorVector.Y * colors[c].G / 255f * cosVR);
                                float B = (float)(Kd * lightColorVector.Z * colors[c].B / 255f * cosN + Ks * lightColorVector.Z * colors[c].B / 255f * cosVR);
                                colors[c] = Color.FromArgb(Algorithms.ClampRGB(R * 255), Algorithms.ClampRGB(G * 255), Algorithms.ClampRGB(B * 255));
                            }
                            break;
                    }

                    for (int c = 0; c <= intersections[i + 1].X - intersections[i].X; c++)
                    {
                        bitmap.SetPixel(intersections[i].X + c, index, colors[c]);
                    }
                }
                count -= AET.RemoveAll(data => data.yMax == index);
                AET.ForEach(data => data.xMin += data.diff);
                index++;
            }
        }

        private void LoadTextureButton_Click(object sender, EventArgs e)
        {
            UnselectAll();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open Image";
            dialog.Filter = "bmp files (*.bmp)|*.bmp|jpg files (*.jpg)|*.jpg;*.jpeg|png files (*.png)|*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                cleanTexture = new Bitmap(dialog.FileName);
                TextureFileName.Text = dialog.SafeFileName;
                texture = new Bitmap(BitmapCanvas.Width, BitmapCanvas.Height);
                using (Graphics g = Graphics.FromImage(texture))
                {
                    TextureBrush b = new TextureBrush(cleanTexture, System.Drawing.Drawing2D.WrapMode.Tile);
                    g.FillRectangle(b, 0, 0, BitmapCanvas.Width, BitmapCanvas.Height);
                }
            }
        }

        private void VertexColorRadioChanged(object sender, EventArgs e)
        {
            if (VertexColorRadioButton.Checked)
            {
                filling = Filling.Color;
            }
        }

        private void TextureRadioChanged(object sender, EventArgs e)
        {
            if (TextureRadioButton.Checked)
            {
                filling = Filling.Texture;
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            texture = new Bitmap(BitmapCanvas.Width, BitmapCanvas.Height);
            using (Graphics g = Graphics.FromImage(texture))
            {
                TextureBrush b = new TextureBrush(cleanTexture, System.Drawing.Drawing2D.WrapMode.Tile);
                g.FillRectangle(b, 0, 0, BitmapCanvas.Width, BitmapCanvas.Height);
            }

            bumpMap = new Bitmap(BitmapCanvas.Width, BitmapCanvas.Height);
            using (Graphics g = Graphics.FromImage(bumpMap))
            {
                TextureBrush b = new TextureBrush(cleanBumpMap, System.Drawing.Drawing2D.WrapMode.Tile);
                g.FillRectangle(b, 0, 0, BitmapCanvas.Width, BitmapCanvas.Height);
            }
        }

        private void LoadBump_Click(object sender, EventArgs e)
        {
            UnselectAll();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open Image";
            dialog.Filter = "bmp files (*.bmp)|*.bmp|jpg files (*.jpg)|*.jpg;*.jpeg|png files (*.png)|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                cleanBumpMap = new Bitmap(dialog.FileName);
                BumpMapName.Text = dialog.SafeFileName;
                bumpMap = new Bitmap(BitmapCanvas.Width, BitmapCanvas.Height);
                using (Graphics g = Graphics.FromImage(bumpMap))
                {
                    TextureBrush b = new TextureBrush(cleanBumpMap, System.Drawing.Drawing2D.WrapMode.Tile);
                    g.FillRectangle(b, 0, 0, BitmapCanvas.Width, BitmapCanvas.Height);
                }
            }
        }

        private void BumpRadioChanged(object sender, EventArgs e)
        {
            if (BumpRadioButton.Checked)
            {
                filling = Filling.Bump;
            }
        }

        private void KdSlider_ValueChanged(object sender, EventArgs e)
        {
            Kd = KdSlider.Value / 100f;
            KdValue.Text = Kd.ToString();
        }

        private void KsSlider_ValueChanged(object sender, EventArgs e)
        {
            Ks = KsSlider.Value / 100f;
            KsValue.Text = Ks.ToString();
        }

        private void LampCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            isLightOn = LampCheckBox.Checked;
            RefreshCanvas();
        }

        private void SetColorButton_Click(object sender, EventArgs e)
        {
            UnselectAll();
            ColorDialog dialog = new ColorDialog();
            dialog.FullOpen = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lightColor = dialog.Color;
                lightColorVector = new Vector3(lightColor.R / 255f, lightColor.G / 255f, lightColor.B / 255f);
                using (Graphics g = Graphics.FromImage(ColorPictureBox.Image))
                {
                    g.Clear(lightColor);
                }
                ColorPictureBox.Refresh();
            }
        }

        private void HeightSliderChanged(object sender, EventArgs e)
        {
            height = HeightSlider.Value / 10f;
            HeightValue.Text = height.ToString();
            RefreshCanvas();
        }
    }
}