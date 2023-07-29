namespace t06_07_InterfaceExercise_WorkflowEngine
{
    public interface IWorkflow
    {
        void AddTask(ITask task);
        void RemoveTask(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}