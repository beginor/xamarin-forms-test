using Android.App;
using Android.OS;
using Xamarin.Forms.Platform.Android;

namespace MasterDetail {

    [Activity(Label = "MasterDetail", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AndroidActivity {

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            //SetContentView(Resource.Layout.Main);
            Xamarin.Forms.Forms.Init(this, bundle);
            SetPage(App.CreatePage());
        }
    }
}

