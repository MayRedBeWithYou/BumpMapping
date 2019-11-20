using System.Collections.Generic;
using System.Drawing;

namespace Zadanie2
{
    public class Edge
    {
        public Vertex From;

        public Vertex To;

        public Polygon Polygon;

        public Color Color = Color.Black;

        public List<Point> Points = new List<Point>(1500);
        public Edge(Vertex f, Vertex t)
        {
            From = f;
            To = t;
        }
    }
}
