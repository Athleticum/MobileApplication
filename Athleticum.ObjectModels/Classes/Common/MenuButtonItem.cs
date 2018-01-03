using Athleticum.ObjectModels.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Athleticum.ObjectModels.Classes.Common
{
    class MenuButtonItem : NotifyPropertyChangedExtended
    {
        // PROPERTIES ----------------------------------------------------------------------------------------------------------
        private ImageSource _image;
        public ImageSource Image
        {
            get { return _image; }
            set { SetField(ref _image, value); }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetField(ref _title, value); }
        }

        private double _opacity = 1.0;
        public double Opacity
        {
            get { return _opacity; }
            set { SetField(ref _opacity, value); }
        }

        private double _imageSizeRequest = -1;
        public double ImageSizeRequest
        {
            get { return _imageSizeRequest; }
            set { SetField(ref _imageSizeRequest, value); }
        }

        private double _buttonWidthRequest = 54;
        public double ButtonWidthRequest
        {
            get { return _buttonWidthRequest; }
            set { SetField(ref _buttonWidthRequest, value); }
        }

        private ICommand _command;
        public ICommand Command
        {
            get { return _command; }
            set { SetField(ref _command, value); }
        }
    }
}
