using Android.Content;
using CustomControls;
using CustomControls.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderlessEditor), typeof(BorderlessEditorRenderer))]
namespace CustomControls.Droid.Renderers
{
    public class BorderlessEditorRenderer : EditorRenderer
    {
        public static void Init() { }
        public BorderlessEditorRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                if (Control != null)
                {
                    Control.Background = null;

                    var layoutParams = new MarginLayoutParams(Control.LayoutParameters);
                    layoutParams.SetMargins(0, 0, 0, 0);
                    LayoutParameters = layoutParams;
                    Control.LayoutParameters = layoutParams;
                    Control.SetPadding(0, 0, 0, 0);
                    SetPadding(0, 0, 0, 0);
                }
            }
        }
    }
}