namespace t06_07_InterfaceExercise_WorkflowEngine
{
    public class Workflow : IWorkflow
    {
        private readonly IList<ITask> _tasks;

        public Workflow()
        {
            _tasks = new List<ITask>();
        }

        public void AddTask(ITask task)
        {
            _tasks.Add(task);
        }

        public void RemoveTask(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }
}