using Portfolio.Catalog.Wpf.Models;
using Portfolio.Catalog.Wpf.Models.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Portfolio.Catalog.Wpf.ViewModels
{
    public class CatalogViewModel : INotifyPropertyChanged
    {
        private readonly ICatalogService _catalogService;

        public CatalogViewModel(ICatalogService catalogService)
        {
            _catalogService = catalogService;
            var items = _catalogService.GetItems();
            _items = new ObservableCollection<CatalogItem>(items);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private ObservableCollection<CatalogItem> _items;
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
