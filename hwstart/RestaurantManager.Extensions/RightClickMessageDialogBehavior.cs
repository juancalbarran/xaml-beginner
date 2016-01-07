using Microsoft.Xaml.Interactivity;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RestaurantManager.Extensions
{
    public class RightClickMessageDialogBehavior : DependencyObject, IBehavior
    {
        public string Message { get; set; }
        public string Title { get; set; }

        public DependencyObject AssociatedObject
        {
            get;
            private set;
        }

        public void Attach(DependencyObject associatedObject)
        {
            AssociatedObject = associatedObject;
            (this.AssociatedObject as Grid).RightTapped += RightClickMessageDialogBehavior_RightTapped;
        }

        private void RightClickMessageDialogBehavior_RightTapped(object sender, Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e)
        {
            new MessageDialog(this.Message, this.Title).ShowAsync();
        }

        public void Detach()
        {
            (this.AssociatedObject as Page).RightTapped -= RightClickMessageDialogBehavior_RightTapped;
        }
    }
}
