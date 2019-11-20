using System.Collections.Generic;
using System.Drawing;

namespace Zadanie2
{
    public class Polygon
    {
        public bool isClosed = false;

        public List<Edge> Edges = new List<Edge>();

        public List<Vertex> Vertices = new List<Vertex>();

        public Color Color = Color.Black;

        public void SetColor(Color color)
        {
            Color = color;

            foreach (Edge e in Edges)
            {
                e.Color = color;
            }
            foreach (Vertex v in Vertices)
            {
                v.Color = color;
            }
        }
    }
}
