namespace Project_KLP_12.Models
{
    public interface IUserRepository
    {
        UserModel Authenticate(string Email, String Password, String Role);
    }
}