using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Content;
using MookieFumiFormsControls.Droid.Controls;
using Android.Views;
using Android.Graphics;

[assembly: ExportRenderer(typeof(Label), typeof(WeCodeLabelRenderer))]
namespace MookieFumiFormsControls.Droid.Controls
{
    public class WeCodeLabelRenderer : LabelRenderer
    {
        public WeCodeLabelRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //if (!string.IsNullOrEmpty(e.NewElement?.FontFamily))
                //{
                //    var font = Typeface.CreateFromAsset(Context.ApplicationContext.Assets, "fonts/" + e.NewElement.FontFamily + ".ttf");
                //    Control.Typeface = font;
                //}
            }
        }
    }
}
