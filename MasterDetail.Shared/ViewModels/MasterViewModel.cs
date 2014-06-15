using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MasterDetail.ViewModels {

    class MasterViewModel : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            var handler = PropertyChanged;
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private ObservableCollection<object> objects = new ObservableCollection<object>();

        public ObservableCollection<object> Objects {
            get {
                return objects;
            }
            set {
                objects = value;
                OnPropertyChanged();
            }
        }

        private string title = "Master";

        public string Title {
            get {
                return title;
            }
            set {
                title = value;
                OnPropertyChanged();
            }
        }

        ICommand add;

        public ICommand Add {
            get {
                return add ?? (add = new Command(() => Objects.Insert(0, DateTime.Now)));
            }
        }
    }
}
