using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
     public class ColorFactory : AbstractFactory
    {
        public override Color getColor(string color)
        {
            if (color == null) return null;
            if (color.ToUpper().Equals("RED")) return new Red();
            if (color.ToUpper().Equals("BLUE")) return new Blue();
            if (color.ToUpper().Equals("GREEN")) return new Green();
            return null;
        }

        public override Shape getShape(string shape)
        {
            return null;
        }
    }
}
