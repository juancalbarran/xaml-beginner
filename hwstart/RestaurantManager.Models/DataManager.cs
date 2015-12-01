using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RestaurantManager.Models
{
    public abstract class DataManager: INotifyPropertyChanged
    {
        protected RestaurantContext Repository { get; private set; }

        public DataManager()
        {
            LoadData();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private async void LoadData()
        {
            this.Repository = new RestaurantContext();
            await this.Repository.InitializeContextAsync();
            OnDataLoaded();
        }

        protected abstract void OnDataLoaded();

        protected void OnPropertyChanged([CallerMemberName]string propName = null)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
