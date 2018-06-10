using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Content;
using MookieFumiFormsControls.Controls;
using MookieFumiFormsControls.Droid.Controls;
using Android.Views;
using Android.Graphics;

[assembly: ExportRenderer(typeof(WeCodeEntry), typeof(WeCodeEntryRenderer))]
namespace MookieFumiFormsControls.Droid.Controls
{
    public class WeCodeEntryRenderer : EntryRenderer
    {
        public WeCodeEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = Android.App.Application.Context.GetDrawable(Resource.Drawable.RoundedButton);
                Control.Gravity = GravityFlags.CenterVertical;
                Control.SetPadding(35, 25, 25, 25);

                //if (!string.IsNullOrEmpty(e.NewElement?.FontFamily))
                //{
                //    var font = Typeface.CreateFromAsset(Context.ApplicationContext.Assets, "fonts/" + e.NewElement.FontFamily + ".ttf");
                //    Control.Typeface = font;
                //}
            }
        }
    }
}
