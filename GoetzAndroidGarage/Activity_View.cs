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
    [Activity(Label = "Activity_View")]
    public class Activity_View : Activity
    {
        private List<string> planets;
        private TextView txtouttie;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);        
            SetContentView(Resource.Layout.ViewRecord);
            txtouttie = FindViewById<TextView>(Resource.Id.txtOut);   

            planets = new List<string> { "ko", "kkk" };
            List<string> planetNames = new List<string>();
            foreach (var item in planets) planetNames.Add(item);

            Spinner spinner = FindViewById<Spinner>(Resource.Id.spinner);

            spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter = new ArrayAdapter<string>(this,Android.Resource.Layout.SimpleSpinnerItem, planetNames);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;
            EditText Input = FindViewById<EditText>(Resource.Id.InputAdd);
            FindViewById<Button>(Resource.Id.btnAdd).Click += (e, o) => 
            spinner.Adapter = BTNAction(txtouttie, Input, planetNames);


        }
        private ArrayAdapter<string> BTNAction(TextView txtouttie, EditText Input, List<string> planetNames)
        {
            txtouttie.Text = Input.Text;
            planetNames.Add(Input.Text);
            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, planetNames);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            Toast.MakeText(this, "koko", ToastLength.Long).Show();
            return adapter;
            
        }
        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            string toast = string.Format("The mean temperature for planet {0} ", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }
    }
}