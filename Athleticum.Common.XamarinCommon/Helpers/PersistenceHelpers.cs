using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Athleticum.Common.XamarinCommon.Helpers
{
    public static class PersistenceHelpers<T>
    {
        public static T GetProperty(string property, T defaultProperty)
        {
            return Application.Current.Properties.ContainsKey(property) ? (T) Application.Current.Properties[property] : defaultProperty;
        }

        public static async Task SaveProperty(string property, object propertyData)
        {
            Application.Current.Properties.Add(property, propertyData);
            await Application.Current.SavePropertiesAsync();
        }


    }
}
