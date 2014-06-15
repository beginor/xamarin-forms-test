using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Forms;

namespace MasterDetail {

    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate {

        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication app, NSDictionary options) {
            Forms.Init();
            Window = new UIWindow(UIScreen.MainScreen.Bounds) {
                RootViewController = App.CreatePage().CreateViewController()
            };
            Window.MakeKeyAndVisible();
            return true;
        }
    }
}