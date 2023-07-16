namespace t03_02_Inheritance
{
    internal class PresentationObject
    {
        internal int Width { get; set; }
        internal int Height { get; set; }

        internal void Copy()
        {
            Console.WriteLine("Object copied to clipboard.");
        }

        internal void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
        }
    }
}