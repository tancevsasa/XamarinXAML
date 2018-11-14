using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinXAML.iOS.Renderers;

[assembly: ExportRenderer(typeof(Entry), typeof(BorderlessEntryRenderer))]
namespace XamarinXAML.iOS.Renderers
{
    public class BorderlessEntryRenderer : EntryRenderer
    {

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}