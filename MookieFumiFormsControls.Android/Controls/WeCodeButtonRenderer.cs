using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Content;
using MookieFumiFormsControls.Controls;
using MookieFumiFormsControls.Droid.Controls;
using Android.Graphics;

[assembly: ExportRenderer(typeof(WeCodeButton), typeof(WeCodeButtonRenderer))]
namespace MookieFumiFormsControls.Droid.Controls
{
    public class WeCodeButtonRenderer : ButtonRenderer
    {
        public WeCodeButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnDraw(Android.Graphics.Canvas canvas)
        {
            base.OnDraw(canvas);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //if (!string.IsNullOrEmpty(e.NewElement?.FontFamily))
                //{
                //    var font = Typeface.CreateFromAsset(Context.ApplicationContext.Assets, "fonts/" + e.NewElement.FontFamily + ".ttf");
                //    Control.Typeface = font;
                //}
                //    Control.Background = Android.App.Application.Context.GetDrawable(Resource.Drawable.RoundedCorner);
                //    Control.Gravity = GravityFlags.CenterVertical;
                //    Control.SetPadding(10, 10, 10, 10);
            }
        }

    }
}
