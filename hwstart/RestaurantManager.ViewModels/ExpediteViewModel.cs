using RestaurantManager.Models;
using System.Collections.Generic;

namespace RestaurantManager.ViewModels
{
    public class ExpediteViewModel : ViewModel
    {
        private List<Order> orderItems = new List<Order>();

        protected override void OnDataLoaded()
        {
            this.OrderItems = base.Repository.Orders;
        }

        public List<Order> OrderItems
        {
            get
            {
                return this.orderItems;
            }
            set
            {
                if (value != this.orderItems)
                {
                    this.orderItems = value;
                    //OnPropertyChanged();
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
