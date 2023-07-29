namespace t06_07_InterfaceExercise_WorkflowEngine
{
    public class WorkflowEngine
    {
        private readonly IList<IWorkflow> _workflows;

        public WorkflowEngine()
        {
            _workflows = new List<IWorkflow>();
        }

        public static void Run(IWorkflow workflow)
        {
            foreach (var wf in workflow.GetTasks())
            {
                wf.Execute();
            }
        }
    }
}