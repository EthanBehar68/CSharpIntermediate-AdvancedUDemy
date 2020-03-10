using System.Collections.Generic;

namespace UDemyCSharpIntermediate
{
    public class Workflow : IWorkflow
    {
        private readonly IList<ITask> _tasks;

        public Workflow()
        {
            _tasks = new List<ITask>();
        }

        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }
}
