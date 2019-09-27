using DependencyService.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;


namespace DependencyService.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public IDeviceOrientationService service;
        public ICommand GetOrientation { get; set; }
        public string Message { get; set; }
        public MainPageViewModel()
        {
            GetOrientation = new Command(() =>
            {
                DeviceOrientation orientation = Xamarin.Forms.DependencyService.Get<IDeviceOrientationService>().GetOrientation();
                
                Message = $"Device Orientation: {orientation.ToString().ToUpper()}";
                //await App.Current.MainPage.DisplayAlert("Orientation", orientation.ToString(), "Ok");
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
