using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamWPFDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuViewMaster : ContentPage
    {
        public ListView ListView;

        public MenuViewMaster()
        {
            InitializeComponent();

            BindingContext = new MenuViewMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MenuViewMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MenuViewMenuItem> MenuItems { get; set; }
            
            public MenuViewMasterViewModel()
            {
                MenuItems = new ObservableCollection<MenuViewMenuItem>(new[]
                {
                    new MenuViewMenuItem { Id = 0, Title = "Projects" },
                    new MenuViewMenuItem { Id = 1, Title = "Clients" },
                    new MenuViewMenuItem { Id = 2, Title = "Calendar" }
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}