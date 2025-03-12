using DAL;

namespace BLL.Interfaces
{
    public interface IProjectService
    {
        public void CreateNewProject();
        public void UpdateProject();
        public void DeleteProject();

        public void CreateNewTask();
        public void UpdateTask(int id, Status status);

        public void AddNewUserToProject();
        public void DeleteUserFromProject();

    }
}
