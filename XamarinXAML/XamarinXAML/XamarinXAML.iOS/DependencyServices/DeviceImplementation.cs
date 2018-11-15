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
                return UIApplication.SharedApplication.KeyWindow.SafeAreaInsets != UIEdgeInsets.Zero;
            }
            else
            {
                return false;
            }
        }
    }
}
