using MasterDetail.ViewModels;
using MasterDetail.Views;
using Xamarin.Forms;

namespace MasterDetail {

    public class App {

        public static Page CreatePage() {
            return new NavigationPage(new MasterView(new MasterViewModel()));
        }
    }
}

