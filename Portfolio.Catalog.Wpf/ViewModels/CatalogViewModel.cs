using Portfolio.Catalog.Wpf.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Portfolio.Catalog.Wpf.ViewModels
{
    public class CatalogViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private ObservableCollection<CatalogItem> _items = new ObservableCollection<CatalogItem>
        {
            new CatalogItem { Name="NameA", Description="DescA" },
            new CatalogItem { Name="NameB", Description="DescB" },
            new CatalogItem { Name="NameC", Description="DescC" },
            new CatalogItem { Name="NameD", Description="DescD" },
        };

        public ObservableCollection<CatalogItem> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }
    }
}
