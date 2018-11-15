using UIKit;
using Xamarin.Forms;
using XamarinXAML.iOS.DependencyServices;

[assembly: Dependency(typeof(DeviceImplementation))]
namespace XamarinXAML.iOS.DependencyServices
{
    public class DeviceImplementation : IDevice
    {
        public bool HasSafeAreas()
        {
            if (UIDevice.CurrentDevice.CheckSystemVersion(11, 0))
            {
                var mika= UIApplication.SharedApplication.KeyWindow.SafeAreaInsets.Bottom != 0;
                return mika;
            }
            else
            {
                return false;
            }
        }
    }
}
