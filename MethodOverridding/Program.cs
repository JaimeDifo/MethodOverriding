using MethodOverridding;
using System.Collections.Generic;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Shape { Width = 100, Height = 100, Type = ShapeType.Circle },
                new Shape { Width = 100, Height = 100, Type = ShapeType.Rectangle }
            };


            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
//Update 28092023 - change