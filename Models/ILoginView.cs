using System;

namespace Project_KLP_12.Views
{
    public interface ILoginView
    {
        string Email { get; set; }
        string Password { get; set; }
        string Role { get; set; }
        string Message { get; set; }
        bool IsLoginSuccessful { get; set; }

        event EventHandler LoginEvent;
    }
}