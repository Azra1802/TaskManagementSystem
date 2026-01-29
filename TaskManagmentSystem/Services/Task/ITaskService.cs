using TaskManagmentSystem.Models;

namespace TaskManagmentSystem.Services.Task
{
    public interface ITaskService
    {
        IEnumerable<TaskModel> GetAllTasks();
        TaskEditVM? GetTaskById(int id);
        void CreateTask(TaskCreateVM taskVM);
        bool UpdateTask(TaskEditVM taskVM);
        bool DeleteTask(int id);
    }
}
