using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //get shape factory
            AbstractFactory shapeFactory = FactoryProducer.getFactory("SHAPE");
            //get an object of Shape Circle
            Shape shape1 = shapeFactory.getShape("CIRCLE");
            //call draw m ethod of Shape Circle
            shape1.draw();
            //get an object of Shape Rectangle
            Shape shape2 = shapeFactory.getShape("RECTANGLE");
            //call draw m ethod of Shape Rectangle
            shape2.draw();
            //get an object of Shape Square
            Shape shape3 = shapeFactory.getShape("SQUARE");
            //call draw m ethod of Shape Square
            shape3.draw();
            
            //get color factory
            AbstractFactory colorFactory = FactoryProducer.getFactory("COLOR");
            //get an object of Color Red
            Color color1 = colorFactory.getColor("RED");
            //call fill m ethod of Red
            color1.fill();
            //get an object of Color Green
            Color color2 = colorFactory.getColor("GREEN");
            //call fill m ethod of Green
            color2.fill();
            //get an object of Color Blue
            Color color3 = colorFactory.getColor("BLUE");
            //call fill m ethod of Color Blue
            color3.fill();
        }
    }
}
