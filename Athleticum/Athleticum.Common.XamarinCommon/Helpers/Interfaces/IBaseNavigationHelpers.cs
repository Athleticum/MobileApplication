using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athleticum.Common.XamarinCommon.Helpers.Interfaces
{
    interface IBaseNavigationHelpers
    {
        void SetRootPage(Type pageType);

        void NavigateToPage(Type toPageType);

        void NavigateToPrevious();

        void NavigateToFeaturePage(string assembly, string pageType);
    }
}
