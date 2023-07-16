namespace t03_02_Inheritance
{
    internal class Text : PresentationObject
    {
        internal int FontSize { get; set; }
        internal string? FontName { get; set; }

        internal void AddHyperLink(string url)
        {
            Console.WriteLine($"We added a link to {url}");
        }
    }
}