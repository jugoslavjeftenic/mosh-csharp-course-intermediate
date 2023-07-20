using System.Collections;

namespace t04_04_Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Boxing(performance penalty) / not type safe
            var list = new ArrayList();
            list.Add(1);
            list.Add("Jugoslav");
            list.Add(DateTime.Today);

            // No Boxing / type safe
            var anotherList = new List<int>();
            anotherList.Add(1);

            var names = new List<string>();
            names.Add("Jugoslav");
        }
    }
}