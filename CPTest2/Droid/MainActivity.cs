using Android.App;
using Android.Widget;
using Android.OS;
using CPTest2.Shared;

namespace CPTest2.Droid
{
    [Activity(Label = "CPTest2", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Calculate calc = new Calculate(1); //int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate { button.Text = $"{calc.PostAdd(1)} clicks!"; }; // count++
        }
    }
}

