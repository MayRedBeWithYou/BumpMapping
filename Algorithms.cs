using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Windows;
using Point = System.Drawing.Point;

namespace Zadanie1
{
    public static class Algorithms
    {
        private static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
        }

        public static void CalculateEdge(Edge e)
        {
            e.Points.Clear();
            int x0 = e.From.Position.X;
            int y0 = e.From.Position.Y;
            int x1 = e.To.Position.X;
            int y1 = e.To.Position.Y;
            bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            if (steep)
            {
                Swap(ref x0, ref y0);
                Swap(ref x1, ref y1);
            }
            if (x0 > x1)
            {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }
            int dX = (x1 - x0);
            int dY = Math.Abs(y1 - y0);
            int err = (dX / 2);
            int ystep = (y0 < y1 ? 1 : -1);
            int y = y0;

            for (int x = x0; x <= x1; ++x)
            {
                if (steep)
                {
                    e.Points.Add(new Point(y, x));
                }
                else
                {
                    e.Points.Add(new Point(x, y));
                }

                err = err - dY;
                if (err < 0)
                {
                    y += ystep;
                    err += dX;
                }
            }
        }

        public static Point GetIntersectionPoint(Edge e1, Edge e2)
        {
            Point s1 = e1.From.Position;
            Point s2 = e1.To.Position;
            Point c1 = e2.From.Position;
            Point c2 = e2.To.Position;
            double d = (c2.Y - c1.Y) * (s2.X - s1.X) - (c2.X - c1.X) * (s2.Y - s1.Y);
            if (d == 0.0)
                return Point.Empty;
            double toSource = ((c2.X - c1.X) * (s1.Y - c1.Y) - (c2.Y - c1.Y) * (s1.X - c1.X)) / d;

            Point s = new Point((int)(s1.X + toSource * (s2.X - s1.X)), (int)(s1.Y + toSource * (s2.Y - s1.Y)));
            return s;
        }
        public static Point GetIntersectionPoint(Point s1, Point s2, Point c1, Point c2)
        {
            double d = (c2.Y - c1.Y) * (s2.X - s1.X) - (c2.X - c1.X) * (s2.Y - s1.Y);
            if (d == 0.0)
                return Point.Empty;
            double toSource = ((c2.X - c1.X) * (s1.Y - c1.Y) - (c2.Y - c1.Y) * (s1.X - c1.X)) / d;

            Point s = new Point((int)(s1.X + toSource * (s2.X - s1.X)), (int)(s1.Y + toSource * (s2.Y - s1.Y)));
            return s;
        }

        public static Point GetScanlineIntersection(Edge e, int h, int width)
        {
            Point s1 = e.From.Position;
            Point e1 = e.To.Position;
            Point s2 = new Point(0, h);
            Point e2 = new Point(width, h);
            float a1 = e1.Y - s1.Y;
            float b1 = s1.X - e1.X;
            float c1 = a1 * s1.X + b1 * s1.Y;

            float a2 = e2.Y - s2.Y;
            float b2 = s2.X - e2.X;
            float c2 = a2 * s2.X + b2 * s2.Y;

            float delta = a1 * b2 - a2 * b1;
            return delta == 0 ? Point.Empty
                : new Point((int)((b2 * c1 - b1 * c2) / delta), (int)((a1 * c2 - a2 * c1) / delta));
        }

        public static Polygon GenerateRandomPolygon(int N, int posY, int posX)
        {
            if (N < 3) return null;
            List<int> X = new List<int>();
            List<int> Y = new List<int>();
            Random rng = new Random();
            for (int i = 0; i < N; i++)
            {
                X.Add(rng.Next(0, 300));
                Y.Add(rng.Next(0, 300));
            }

            X.Sort();
            int minX = X[0];
            int maxX = X[X.Count - 1];
            X.RemoveAt(0);
            X.RemoveAt(X.Count - 1);


            Y.Sort();
            int minY = Y[0];
            int maxY = Y[Y.Count - 1];
            Y.RemoveAt(0);
            Y.RemoveAt(Y.Count - 1);

            List<int> X1 = new List<int>();
            List<int> X2 = new List<int>();
            List<int> Y1 = new List<int>();
            List<int> Y2 = new List<int>();

            X1.Add(minX);
            X2.Add(minX);
            Y1.Add(minY);
            Y2.Add(minY);

            for (int i = 0; i < N - 2; i++)
            {
                if (i % 2 == 0)
                {
                    X1.Add(X[i]);
                    Y1.Add(Y[i]);
                }
                else
                {
                    X2.Add(X[i]);
                    Y2.Add(Y[i]);
                }
            }

            X1.Add(maxX);
            X2.Add(maxX);
            Y1.Add(maxY);
            Y2.Add(maxY);

            List<Vector> Vx1 = new List<Vector>();
            List<Vector> Vx2 = new List<Vector>();

            List<Vector> Vy1 = new List<Vector>();
            List<Vector> Vy2 = new List<Vector>();

            X2.Reverse();
            Y2.Reverse();
            for (int i = 0; i < X1.Count - 1; i++)
            {
                Vx1.Add(new Vector(X1[i + 1] - X1[i], 0));
                Vy1.Add(new Vector(0, Y1[i + 1] - Y1[i]));
            }

            for (int i = 0; i < X2.Count - 1; i++)
            {
                Vx2.Add(new Vector(X2[i + 1] - X2[i], 0));
                Vy2.Add(new Vector(0, Y2[i + 1] - Y2[i]));
            }

            List<Vector> Vx = new List<Vector>();
            List<Vector> Vy = new List<Vector>();

            Vx.AddRange(Vx1);
            Vx.AddRange(Vx2);
            Vy.AddRange(Vy1);
            Vy.AddRange(Vy2);

            List<Vector> V = new List<Vector>();

            while (Vx.Count != 0)
            {
                Vector xx = Vx[rng.Next(0, Vx.Count - 1)];
                Vx.Remove(xx);
                Vector yy = Vy[rng.Next(0, Vy.Count - 1)];
                Vy.Remove(yy);
                V.Add(xx + yy);
            }

            V.Sort((v1, v2) => (int)(Vector.AngleBetween(new Vector(0, 1), v2) - Vector.AngleBetween(new Vector(0, 1), v1)));

            Polygon p = new Polygon();
            p.Vertices.Add(new Vertex(posX, posY));

            for (int i = 0; i < V.Count - 1; i++)
            {
                p.Vertices.Add(new Vertex((int)(p.Vertices[i].Position.X + V[i].X), (int)(p.Vertices[i].Position.Y + V[i].Y)));
                p.Edges.Add(new Edge(p.Vertices[i], p.Vertices[i + 1]));
                p.Vertices[i].Polygon = p;
                p.Vertices[i].Color = Color.FromArgb(rng.Next(0, 255), rng.Next(0, 255), rng.Next(0, 255));
                p.Edges[i].Polygon = p;
            }
            p.Edges.Add(new Edge(p.Vertices[V.Count - 1], p.Vertices[0]));
            p.Edges.Last().Polygon = p;
            p.isClosed = true;
            foreach (Edge e in p.Edges)
            {
                CalculateEdge(e);
            }
            return p;
        }

        private static bool IsInside(Edge edge, Point test)
        {
            bool? isLeft = IsLeftOf(edge, test);
            if (isLeft == null)
            {
                return true;
            }

            return !isLeft.Value;
        }

        private static bool? IsLeftOf(Edge edge, Point test)
        {
            Point tmp1 = new Point(edge.To.Position.X - edge.From.Position.X, edge.To.Position.Y - edge.From.Position.Y);
            Point tmp2 = new Point(test.X - edge.To.Position.X, test.Y - edge.To.Position.Y);

            double x = (tmp1.X * tmp2.Y) - (tmp1.Y * tmp2.X);

            if (x < 0)
            {
                return false;
            }
            else if (x > 0)
            {
                return true;
            }
            else
            {
                return null;
            }
        }

        public static int GetFarLeft(Polygon poly)
        {
            int min = poly.Vertices[0].Position.X;
            foreach (Vertex v in poly.Vertices)
            {
                if (min > v.Position.X)
                {
                    min = v.Position.X;
                }
            }
            return min;
        }

        public static int GetFarRight(Polygon poly)
        {
            int max = poly.Vertices[0].Position.X;
            foreach (Vertex v in poly.Vertices)
            {
                if (max < v.Position.X)
                {
                    max = v.Position.X;
                }
            }
            return max;
        }

        public static Point[] GetIntersectedPolygon(Polygon subjectPoly, Polygon clipPoly)
        {
            List<Point> outputList = new List<Point>();
            foreach (Vertex v in subjectPoly.Vertices) outputList.Add(v.Position);

            foreach (Edge clipEdge in clipPoly.Edges)
            {
                List<Point> inputList = outputList.ToList();
                outputList.Clear();

                if (inputList.Count == 0)
                {
                    break;
                }

                Point S = inputList[inputList.Count - 1];

                foreach (Point E in inputList)
                {
                    if (IsInside(clipEdge, E))
                    {
                        if (!IsInside(clipEdge, S))
                        {
                            Point point = GetIntersectionPoint(S, E, clipEdge.From.Position, clipEdge.To.Position);
                            if (point != Point.Empty)
                            {
                                outputList.Add(point);
                            }
                        }

                        outputList.Add(E);
                    }
                    else if (IsInside(clipEdge, S))
                    {
                        Point point = GetIntersectionPoint(S, E, clipEdge.From.Position, clipEdge.To.Position);
                        if (point != Point.Empty)
                        {
                            outputList.Add(point);
                        }
                    }
                    S = E;
                }
            }
            return outputList.ToArray();
        }

        public static Color CalculateColor(Polygon poly, Point p)
        {
            double sum = 0;
            double red = 0;
            double green = 0;
            double blue = 0;
            foreach (Vertex v in poly.Vertices)
            {
                double dist = 1 / (Distance(p, v.Position) + 1);
                sum += dist;
                red += v.Color.R * dist;
                green += v.Color.G * dist;
                blue += v.Color.B * dist;
            }

            return Color.FromArgb(255, (int)(red / sum), (int)(green / sum), (int)(blue / sum));
        }

        public static double Cos(Vector3 N)
        {
            return Cos(N, new Vector3(0, 0, 1));
        }

        public static double Cos(Vector3 N, Vector3 L)
        {
            return N.X * L.X + N.Y * L.Y + N.Z * L.Z;
        }

        public static int ClampRGB(float C)
        {
            if (C < 0) return 0;
            if (C > 255) return 255;
            return (int)C;
        }
    }
}
