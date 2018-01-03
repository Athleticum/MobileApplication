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
    public static class NavigationHelpers
    {
        private static NavigationPage _navigationPage;

        public static async void NavigateToFeaturePage(string pageType, string assembly)
        {
            if (_navigationPage != null)
            {
                ContentPage page = ReflectionHelpers<ContentPage>.CreateObject(pageType, pageType);
                await _navigationPage.PushAsync(page);
            }
        }

        public static async void NavigateToPage(Type toPageType)
        {
            if (_navigationPage != null)
            {
                ContentPage page = (ContentPage)Activator.CreateInstance(toPageType);
                await _navigationPage.PushAsync(page);
            }
        }

        public static async void NavigateToHome()
        {
            if (_navigationPage != null)
            {
                await _navigationPage.Navigation.PopToRootAsync();
            }
        }

        public static async void NavigateToPrevious()
        {
            if (_navigationPage != null)
            {
                await _navigationPage.PopAsync();
            }
        }

        public static void SetRootPage(Type pageType)
        {
            ContentPage page = (ContentPage)Activator.CreateInstance(pageType);
            _navigationPage = new NavigationPage(page);
        }
    }
}
