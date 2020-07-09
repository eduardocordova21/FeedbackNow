using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FeedbackNow.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public DelegateCommand GoToCreateAccountPageCommand { get; private set; }

        public DelegateCommand LoginCommand { get; private set; }

        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            GoToCreateAccountPageCommand = new DelegateCommand(GoToCreateAccountPage);
            LoginCommand = new DelegateCommand(Login);
        }

        private void GoToCreateAccountPage()
        {
            _navigationService.NavigateAsync("CreateAccountPage");
        }

        private void Login()
        {
            _navigationService.NavigateAsync("MenuPage/NavigationPage/MainPage");
        }
    }
}
