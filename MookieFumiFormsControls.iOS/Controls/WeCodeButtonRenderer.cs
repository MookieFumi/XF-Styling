using MookieFumiFormsControls.Controls;
using MookieFumiFormsControls.iOS.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(WeCodeButton), typeof(WeCodeButtonRenderer))]
namespace MookieFumiFormsControls.iOS.Controls
{
    public class WeCodeButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Layer.BorderWidth = 1;
                Control.Layer.BorderColor = Color.FromHex("d3d3d3").ToCGColor();
            }
        }
    }
}