using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FeedbackNow.ViewModels
{
    public class CreateAccountPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public DelegateCommand GoToLoginPageCommand { get; private set; }

        public CreateAccountPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            GoToLoginPageCommand = new DelegateCommand(GoToLoginPage);
        }

        private void GoToLoginPage()
        {
            _navigationService.NavigateAsync("LoginPage");
        }
    }
}
