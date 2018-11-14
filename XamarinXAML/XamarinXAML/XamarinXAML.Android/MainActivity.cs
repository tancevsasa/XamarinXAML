using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CarouselView.FormsPlugin.Android;
using Xamarin.Forms.Platform.Android;

namespace XamarinXAML.Droid
{
    [Activity(Label = "XamarinXAML", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            InitControls();

            Window.AddFlags(WindowManagerFlags.TranslucentStatus);


            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

           LoadApplication(new App());
        }

        private void InitControls()
        {
            CarouselViewRenderer.Init();
        }
    }
}