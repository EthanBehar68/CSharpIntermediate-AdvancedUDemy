using System.Collections.Generic;

namespace CSharpIntermediateUDemy
{
    public interface IWorkflow
    {
        void Add(ITask task);

        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}
