using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace ListView1
{
    [Activity(Label = "ListView1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        private List<string> nItems;
        private ListView nListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            nListView = FindViewById<ListView>(Resource.Id.myListView);

            nItems = new List<string>();
            nItems.Add("Bob");
            nItems.Add("Lebron");
            nItems.Add("Carl"); 
            nItems.Add("Bishop");
            nItems.Add("Neptune");
            nItems.Add("Namor");
            nItems.Add("Medusa");
            nItems.Add("Aquaman");
            nItems.Add("Kid Flash");
            nItems.Add("Wendigo");
            nItems.Add("Sentinel");
            nItems.Add("Puck");





            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this,Android.Resource.Layout.SimpleListItem1, nItems);


            nListView.Adapter = adapter;
        }
    }
}

