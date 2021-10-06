using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GoetzAndroidGarage
{
    [Activity(Label = "Activity_New")]
    public class Activity_New : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.NewRecord);

            var CustomerInput = FindViewById<EditText>(Resource.Id.InputCustomer);
            var PhoneNumber = FindViewById<EditText>(Resource.Id.InputPhone);
            var VehicleNumber = FindViewById<EditText>(Resource.Id.InputVehicleYear);
            var VehicleMake = FindViewById<EditText>(Resource.Id.InputVehicleMake);
            var VehicleModel = FindViewById<EditText>(Resource.Id.InputVehicleModel);
            var VinNumber = FindViewById<EditText>(Resource.Id.InputVIN);
            var LicensePlate = FindViewById<EditText>(Resource.Id.InputLicensePlate);
            var Date = FindViewById<EditText>(Resource.Id.InputDate);
            var KM = FindViewById<EditText>(Resource.Id.InputKm);
            var EngineSize = FindViewById<EditText>(Resource.Id.InputEngineSizee);

            FindViewById<Button>(Resource.Id.btnSubmit).Click += (e, o) =>

            KM.Text = "Lol";
            AlertDialog.Builder alertDialog = new AlertDialog.Builder(this);
            alertDialog.SetTitle("Entering Invoice Details");
            alertDialog.SetMessage("222");
            alertDialog.SetNeutralButton("OK", delegate
            {
                alertDialog.Dispose();
            });
        }

        private void submitMessage()
        {
            AlertDialog.Builder alertDialog = new AlertDialog.Builder(this);
            alertDialog.SetTitle("Entering Invoice Details");
            alertDialog.SetMessage("222");
            alertDialog.SetNeutralButton("OK", delegate
            {
                alertDialog.Dispose();
            });

        }
    }
}