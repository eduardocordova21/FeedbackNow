using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FeedbackNow.ViewModels
{
    public class MenuPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public DelegateCommand<string> NavigateMenuCommand { get; private set; }

        public MenuPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            NavigateMenuCommand = new DelegateCommand<string>(NavigateMenu);
        }

        private void NavigateMenu(string pageName)
        {
            if (pageName == "LoginPage")
            {
                _navigationService.NavigateAsync(string.Format("{0}", pageName));
            }
            else
            {
                _navigationService.NavigateAsync(string.Format("MenuPage/NavigationPage/{0}", pageName));
            }
        }
    }
}
