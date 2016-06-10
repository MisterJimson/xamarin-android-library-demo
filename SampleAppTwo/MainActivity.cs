using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using SampleLibTwo;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace SampleAppTwo
{
    [Activity(Label = "SampleAppOne", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            SetSupportActionBar(FindViewById<Toolbar>(Resource.Id.toolbar));


            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            SampleClassTwo sampleClassOne = FindViewById<SampleClassTwo>(Resource.Id.sample);

            sampleClassOne.SetText("sample text", TextView.BufferType.Normal);
        }
    }
}

