using System;
using Project_KLP_12.Models;
using Project_KLP_12.Views;

namespace Project_KLP_12.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _view;
        private readonly IUserRepository _userRepository;

        public LoginPresenter(ILoginView view, IUserRepository userRepository)
        {
            _view = view;
            _userRepository = userRepository;
            _view.LoginEvent += OnLogin;
        }

        private void OnLogin(object sender, EventArgs e)
        {
            var user = _userRepository.Authenticate(_view.Email, _view.Password, _view.Role);
            if (user != null)
            {
                _view.Message = "Login Berhasil! Selamat datang, " + user.Name;
                _view.IsLoginSuccessful = true;
            }
            else
            {
                _view.Message = "Login Gagal! Periksa kembali Email, Password, atau Role Anda.";
                _view.IsLoginSuccessful = false;
            }
        }
    }
}