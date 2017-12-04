using Athleticum.Common.Helpers.Helpers;
using Athleticum.Common.XamarinCommon.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Athleticum.Common.XamarinCommon.Helpers
{
    public class NavigationHelpers : IBaseNavigationHelpers
    {
        private static NavigationHelpers _instance;

        private NavigationPage _navigationPage;

        private NavigationHelpers() { }

        public static NavigationHelpers Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NavigationHelpers();
                }
                return _instance;
            }
        }

        public async void NavigateToFeaturePage(string pageType, string assembly)
        {
            if (_navigationPage != null)
            {
                ContentPage page = ReflectionHelpers<ContentPage>.CreateObject(pageType, pageType);
                await _navigationPage.PushAsync(page);
            }
        }

        public async void NavigateToPage(Type toPageType)
        {
            if (_navigationPage != null)
            {
                ContentPage page = (ContentPage)Activator.CreateInstance(toPageType);
                await _navigationPage.PushAsync(page);
            }
        }

        public async void NavigateToPrevious()
        {
            if (_navigationPage != null)
            {
                await _navigationPage.PopAsync();
            }
        }

        public void SetRootPage(Type pageType)
        {
            ContentPage page = (ContentPage)Activator.CreateInstance(pageType);
            _navigationPage = new NavigationPage(page);
        }
    }
}
