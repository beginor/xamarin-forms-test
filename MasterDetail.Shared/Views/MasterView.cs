using MasterDetail.ViewModels;
using Xamarin.Forms;

namespace MasterDetail.Views {

    class MasterView : ContentPage {

        public MasterView(MasterViewModel viewModel) {
            BindingContext = viewModel;

            SetBinding(TitleProperty, new Binding("Title"));

            var listView = new ListView {
                BindingContext = viewModel,
                VerticalOptions = new LayoutOptions(LayoutAlignment.Fill, true),
                HorizontalOptions = new LayoutOptions(LayoutAlignment.Fill, true),
            };

            listView.SetBinding(ListView.ItemsSourceProperty, "Objects");
            listView.ItemTapped += OnListViewOnItemTapped;

            Content = listView;

            var addItem = new ToolbarItem {
                Name = "Add",
                Icon = "Add.png",
                BindingContext = viewModel
            };
            addItem.SetBinding(ToolbarItem.CommandProperty, "Add");

            ToolbarItems.Add(addItem);
        }

        private void OnListViewOnItemTapped(object sender, ItemTappedEventArgs e) {
            if (e.Item != null) {
                Navigation.PushAsync(new DetailView(e.Item));
            }
            
        }
    }
}
