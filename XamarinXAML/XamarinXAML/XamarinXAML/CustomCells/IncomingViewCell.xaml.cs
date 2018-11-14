using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinXAML.CustomCells
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IncomingViewCell : ViewCell
    {
		public IncomingViewCell ()
		{
			InitializeComponent ();
		}

        private void SKCanvasView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKImageInfo info = e.Info;
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;
            canvas.Clear();

            int cornerRadius = info.Width / 14;

            using (SKPath path = new SKPath())
            {
                path.MoveTo(0, 0);
                path.LineTo(info.Width - cornerRadius, 0);

                path.CubicTo(info.Width, 0, info.Width, info.Height, info.Width - cornerRadius, info.Height);
                path.LineTo(cornerRadius, info.Height);

                path.QuadTo(0, info.Height, 0, info.Height - cornerRadius);
                path.LineTo(0, 0);

                SKPaint paint = new SKPaint
                {
                    Style = SKPaintStyle.StrokeAndFill,
                    Color = ((Color)App.Current.Resources["firstMessage"]).ToSKColor(),
                    StrokeWidth = 1,
                    IsAntialias = true
                };

                canvas.DrawPath(path, paint);
            }
        }
    }
}