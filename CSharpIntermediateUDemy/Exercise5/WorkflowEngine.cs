namespace CSharpIntermediateUDemy
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            // Not safests or more descriptive Run method.
            foreach (var obj in workflow.GetTasks())
                obj.Execute();
        }

    }
}
