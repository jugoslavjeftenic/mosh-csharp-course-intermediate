namespace t02_08_Indexers
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();

            cookie["name"] = "Jugoslav";

            Console.WriteLine(cookie["name"]);
        }
    }
}