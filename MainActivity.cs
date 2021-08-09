using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;
using Android.Views;

namespace RadioButton_Xamarin_Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        RadioGroup rbGroup;
        RadioButton rbMale;
        RadioButton rbFemale;
        Button btnSelection;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // Get our button from the layout resource,
            // and attach an event to it

            rbMale = FindViewById<RadioButton>(Resource.Id.rbMale);
            rbFemale = FindViewById<RadioButton>(Resource.Id.rbFemale);
            btnSelection = FindViewById<Button>(Resource.Id.btnSelection);

            rbGroup = FindViewById<RadioGroup>(Resource.Id.widget39);

            btnSelection.Click += OnButtonSelectionClick;
        }
        void OnButtonSelectionClick(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                Toast.MakeText(this, "Male selected", ToastLength.Long).Show();
            }
            else if (rbFemale.Checked)
            {
                Toast.MakeText(this, "Female selected", ToastLength.Long).Show();
            }

            // to change the text of the radio button at run time 
            View v = rbGroup.GetChildAt(0);
            RadioButton test = (RadioButton)v;
            test.Text = "Testing";
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}