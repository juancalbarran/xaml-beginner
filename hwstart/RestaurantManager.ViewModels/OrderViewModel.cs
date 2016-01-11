using RestaurantManager.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Popups;

namespace RestaurantManager.ViewModels
{
    public class OrderViewModel : ViewModel
    {
        private List<MenuItem> menuItems = new List<MenuItem>();

        private ObservableCollection<MenuItem> currentlySelectedMenuItems = new ObservableCollection<MenuItem>();

        public DelegateCommand<int> AddMenuItemCommand { get; set; }

        public DelegateCommand<string> AddNewOrderCommand { get; set; }

        public OrderViewModel()
        {
            this.AddMenuItemCommand = new DelegateCommand<int>(AddMenuItemExecute);
            this.AddNewOrderCommand = new DelegateCommand<string>(AddNewOrderExecute);
        }

        private void AddNewOrderExecute(string specialRequests)
        {
            var order = new Order { Complete = false, Expedite = false, SpecialRequests = specialRequests, Table = this.Repository.Tables.First(), Items = new List<MenuItem>() };

            foreach (MenuItem item in CurrentlySelectedMenuItems)
            {
                order.Items.Add(item);
            }

            base.Repository.Orders.Add(order);

            new MessageDialog("Order has been submitted").ShowAsync();
        }

        private void AddMenuItemExecute(int index)
        {
            var item = MenuItems[index];
            CurrentlySelectedMenuItems.Add(item);
        }

        protected override void OnDataLoaded()
        {
            this.MenuItems = base.Repository.StandardMenuItems;

            //this.CurrentlySelectedMenuItems = new ObservableCollection<MenuItem>
            //{
            //    this.MenuItems[3],
            //    this.MenuItems[5]
            //};
        }

        public List<MenuItem> MenuItems
        {
            get
            {
                return this.menuItems;
            }
            set
            {
                if (value != this.menuItems)
                {
                    this.menuItems = value;
                    //OnPropertyChanged();
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<MenuItem> CurrentlySelectedMenuItems
        {
            get
            {
                return this.currentlySelectedMenuItems;
            }
            set
            {
                if (value != this.currentlySelectedMenuItems)
                {
                    this.currentlySelectedMenuItems = value;
                    //OnPropertyChanged();
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
