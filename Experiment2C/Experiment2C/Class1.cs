using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Experiment2C
{
    class Class1
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please choose any from the follwing list");
            Console.WriteLine("1\n" + "2\n" + "3\n");

            Console.WriteLine("Type your answer: ");

            string input = Console.ReadLine();

            Circle desc1 = new Circle();
            Rectangle desc2 = new Rectangle();
            Cylinder desc3 = new Cylinder();

            
            switch (input)
            {
                case "1":
                    desc1.circle();

                    break;
                
                case "2":
                    desc2.rectangle();
                    
                    break;
                
                case "3":
                    desc3.cylinder();
                    
                    break;

            }

        }

        class Circle
        {
            public void circle()
            {
                Console.WriteLine("A circle is a round-shaped figure that has no corners or edges\n" +
                    "The center of a circle is the center point in a circle from which all the distances to the points on the circle are equal. This distance is called the radius of the circle.\n" +
                    "The circumference of a circle is the distance around a circle.It is the same as the perimeter of other shapes.");
            }

        }

        class Rectangle
        {
            public void rectangle()
            {

                Console.WriteLine("A Rectangle is a four sided-polygon, having all the internal angles equal to 90 degrees. The two sides at each corner or vertex, meet at right angles. The opposite sides of the rectangle are equal in length which makes it different from a square.\n " +
                    "A rectangle is a type of quadrilateral that has its parallel sides equal to each other and all the four vertices are equal to 90 degrees. Hence, it is also called an equiangular quadrilateral.\n" +
                    "A rectangle is a two-dimensional flat shape. In an XY plane, we can easily represent a rectangle, where the arms of x-axis and y-axis show the length and width of the rectangle, respectively.");
            }
        }

        class Cylinder
        {
            public void cylinder()
            {

                Console.WriteLine("In mathematics, a cylinder is a three-dimensional solid that holds two parallel bases joined by a curved surface, at a fixed distance. These bases are normally circular in shape (like a circle) and the center of the two bases are joined by a line segment, which is called the axis. The perpendicular distance between the bases is the height, “h” and the distance from the axis to the outer surface is the radius “r” of the cylinder.\n " +
                    "The bases are always congruent and parallel.\n" +
                    "It is similar to the prism since it has the same cross-section everywhere.\n");
            }
        }
    }
}
