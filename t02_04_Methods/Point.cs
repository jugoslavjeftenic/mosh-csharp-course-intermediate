namespace t02_04_Methods
{
    internal class Point
    {
        internal int X;
        internal int Y;

        internal Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        internal void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        internal void Move(Point newLocation)
        {
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }

            Move(newLocation.X, newLocation.Y);
        }
    }
}