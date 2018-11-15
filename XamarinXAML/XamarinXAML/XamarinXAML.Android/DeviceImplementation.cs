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

namespace XamarinXAML.Droid
{
    public class DeviceImplementation : IDevice
    {
        public bool HasSafeAreas()
        {
            if (UIDevice.CurrentDevice.CheckSystemVersion(11, 0))
            {
                return UIApplication.SharedApplication.KeyWindow.SafeAreaInsets != UIEdgeInsets.Zero;
            }
            else
            {
                return false;
            }
        }
    }
}