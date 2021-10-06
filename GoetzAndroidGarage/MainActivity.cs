using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace GoetzAndroidGarage
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource

            // Main Code

            SetContentView(Resource.Layout.activity_main);

            FindViewById<Button>(Resource.Id.btnViewRecord).Click += (e, o) =>
            ViewPage();

            FindViewById<Button>(Resource.Id.btnNewRecord).Click += (e, o) =>
            NewPage();
        }

        private void ViewPage()
        {
            Intent intent = new Intent(this, typeof(Activity_View));
            StartActivity(intent);
        }

        private void NewPage()
        {
            Intent intent = new Intent(this, typeof(Activity_New));
            StartActivity(intent);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}