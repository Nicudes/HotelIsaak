using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace IsaakHotel.Droid
{
    [Activity(Label = "IsaakHotel", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        //public FirebaseFirestore GetFirestore()
        //{
        //    var app = FirebaseApp.InitializeApp(this);
            

        //    if (app == null)
        //    {
        //        var options = new FirebaseOptions.Builder()
        //            .SetProjectId("isaachotel-b0409")
        //            .SetApplicationId("isaachotel-b0409")//kanske fel
        //            .SetApiKey("AIzaSyDiM6f_NRZUF5noVcFy1yJM_mZgstGcf5Q")
        //            .SetDatabaseUrl("https://isaachotel-b0409.firebaseio.com")
        //            .SetStorageBucket("isaachotel-b0409.appspot.com")
        //            .Build();

        //        app = FirebaseApp.InitializeApp(this, options); //fore app to initialize
        //        database = FirebaseFirestore.GetInstance(app);
        //    }
        //    else
        //    {
        //        database = FirebaseFirestore.GetInstance(app);
        //    }

        //    return database;
        //}
    }
}