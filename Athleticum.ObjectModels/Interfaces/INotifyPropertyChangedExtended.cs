using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Athleticum.ObjectModels.Interfaces
{
    public interface INotifyPropertyChangedExtended : INotifyPropertyChanged
    {
        bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null);

        void OnPropertyChanged(string propertyName);
    }
}
