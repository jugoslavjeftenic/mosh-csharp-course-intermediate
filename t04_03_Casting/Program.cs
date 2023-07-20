using System.Collections;

namespace t04_03_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Upcasting
            // Example 1.
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);

            // Example 2.
            StreamReader reader = new StreamReader(new MemoryStream());

            // Example 3.
            var list = new ArrayList();
            list.Add(1);
            list.Add("Jugoslav");
            list.Add(new Text());

            // Example 4.
            var anotherList = new List<Shape>();


            // Downcasting
            Shape shapeDowncast = new Text();
            Text textDowncast = (Text)shapeDowncast;
        }
    }
}