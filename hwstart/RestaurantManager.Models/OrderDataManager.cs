using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class OrderDataManager : DataManager
    {
        private List<MenuItem> menuItems = new List<MenuItem>();
        private List<MenuItem> currentlySelectedMenuItems = new List<MenuItem>();

        protected override void OnDataLoaded()
        {
            this.MenuItems = base.Repository.StandardMenuItems;

            this.CurrentlySelectedMenuItems = new List<MenuItem>
            {
                this.MenuItems[3],
                this.MenuItems[5]
            };
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
                    OnPropertyChanged();
                }
            }
        }

        public List<MenuItem> CurrentlySelectedMenuItems
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
                    OnPropertyChanged();
                }
            }
        }
    }
}
