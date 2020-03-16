using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ChipGroup_GettingStarted
{
    public class Language :INotifyPropertyChanged
    {
        public string Name
        {
            get;
            set;
        }

        private Color textColor = Color.White;



        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TextColor"));
            }
        }

        private bool isChecked = false;



        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                isChecked = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsChecked"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
