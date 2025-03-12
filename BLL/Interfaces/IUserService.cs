namespace BLL.Interfaces
{
    public interface IUserService
    {
        public void CreateUser();
        public void UpdateUser();
        public void DeleteUser();

        public void CreateNewTag();
        public void UpdateTag();
        public void DeleteTag();

        public void AddComment();
        public void UpdateComment();
        public void DeleteComment();
    }
}
