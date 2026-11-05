namespace Project_KLP_12.Models
{
    public interface IUserRepository
    {
        UserModel Authenticate(string email, string password, string role);
    }
}