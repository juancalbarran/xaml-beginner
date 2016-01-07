using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RestaurantManager.Models
{
    public class ExpediteDataManager : DataManager
    {
        //TODO:Delete
        public bool IsActive { get { return true; } }

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
                    OnPropertyChanged();
                }
            }
        }
    }
}
