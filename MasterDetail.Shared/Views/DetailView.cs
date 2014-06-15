using MasterDetail.ViewModels;
using Xamarin.Forms;

namespace MasterDetail.Views {

    class DetailView : ContentPage {

        public DetailView(object obj) {

            Title = "Detail";

            var label = new Label {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = obj.ToString()
            };

            Content = label;
        }
    }
}
