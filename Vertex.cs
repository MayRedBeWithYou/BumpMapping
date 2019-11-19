using System.Collections.Generic;
using System.Drawing;

namespace Zadanie1
{
    public class Vertex
    {
        public Point Position = Point.Empty;

        public List<Edge> Edges = new List<Edge>();

        public Polygon Polygon;

        public Color Color = Color.Black;

        public int Size = 9;

        public Vertex()
        {

        }

        public Vertex(int x, int y)
        {
            Position.X = x;
            Position.Y = y;
        }

        public Edge GetEdge(Vertex to)
        {
            foreach (Edge e in Edges)
            {
                if (e.To == to || e.From == to)
                {
                    return e;
                }
            }
            return null;
        }

        public Vertex GetAdjecentVertex(Edge e)
        {
            if (e.To == this)
            {
                return e.From;
            }
            if (e.From == this)
            {
                return e.To;
            }
            return null;
        }

        public (Vertex, Vertex) GetNeighbors()
        {
            List<Vertex> vertices = new List<Vertex>();
            foreach (Edge e in Edges)
            {
                vertices.Add(GetAdjecentVertex(e));
            }
            vertices.Add(null);
            vertices.Add(null);
            return (vertices[0], vertices[1]);
        }
    }
}
