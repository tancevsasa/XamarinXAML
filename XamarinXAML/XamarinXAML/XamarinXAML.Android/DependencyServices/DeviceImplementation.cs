using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XamarinXAML.Droid.DependencyServices;

[assembly: Dependency(typeof(DeviceImplementation))]
namespace XamarinXAML.Droid.DependencyServices
{
    public class DeviceImplementation : IDevice
    {
        public bool HasSafeAreas()
        {
            return false;
        }
    }
}