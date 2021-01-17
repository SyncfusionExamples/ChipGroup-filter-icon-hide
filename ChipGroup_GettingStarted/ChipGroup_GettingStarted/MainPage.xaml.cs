using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChipGroup_GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SessionListFilterOptions_SelectionChanged(object sender, Syncfusion.Buttons.XForms.SfChip.SelectionChangedEventArgs e)
        {
            if (e.AddedItem != null)
            {
                (e.AddedItem as Language).IsChecked = true;
            }

            if (e.RemovedItem != null)
            {
                (e.RemovedItem as Language).IsChecked = false;
            }
        }

    }
}
