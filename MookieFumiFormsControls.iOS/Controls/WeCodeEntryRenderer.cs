using Xamarin.Forms;
using MookieFumiFormsControls.Controls;
using MookieFumiFormsControls.iOS.Controls;
using Xamarin.Forms.Platform.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(WeCodeEntry), typeof(WeCodeEntryRenderer))]
namespace MookieFumiFormsControls.iOS.Controls
{
    public class WeCodeEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor = UIColor.White;
                Control.TextColor = UIColor.Gray;
            }
        }
    }
}