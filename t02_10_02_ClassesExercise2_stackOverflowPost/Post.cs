namespace t02_10_02_ClassesExercise2_stackOverflowPost
{
    internal class Post
    {
        internal string? Title { get; set; }
        internal string? Description { get; set; }
        internal DateTime Created { get; set; }
        private int _vote;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            Created = DateTime.Now;
            _vote = 0;
        }

        public int Vote
        {
            get { return _vote; }
        }

        internal void UpVote()
        {
            _vote++;
        }

        internal void DownVote()
        {
            _vote--;
        }
    }
}