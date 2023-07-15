namespace t02_10_01_ClassesExercise1_stopwatch
{
    internal class Stopwatch
    {
        public DateTime StartTime { get; private set; }
        public DateTime StopTime { get; private set; }
        internal TimeSpan Duration { get; private set; }

        public Stopwatch()
        {
            Duration = TimeSpan.FromMilliseconds(1);
        }

        internal void Start()
        {
            if (Duration == TimeSpan.Zero)
            {
                throw new InvalidOperationException("Stopwatch is already started!");
            }
            StartTime = DateTime.Now;
            Duration = TimeSpan.Zero;
        }

        internal void Stop()
        {
            if (Duration == TimeSpan.Zero)
            {
                StopTime = DateTime.Now;
                Duration = StopTime - StartTime;
            }
        }
    }
}