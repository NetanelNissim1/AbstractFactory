using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   public class ShapeFactory : AbstractFactory
    {
        public override Shape getShape(string shapeType)
        {
            if (shapeType == null) return null;

            if (shapeType.ToUpper().Equals("CIRCLE")) return new Circle();

            if (shapeType.ToUpper().Equals("RECTANGLE")) return new Rectangle();

            if (shapeType.ToUpper().Equals("SQUARE")) return new Square();

            return null;
        }

        public override Color getColor(string color)
        {
            return null;
        }
    }
}
