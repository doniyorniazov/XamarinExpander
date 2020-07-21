using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamarinExpander
{
    public class Message : INotifyPropertyChanged
    {
        string header;
        public string Header
        {
            get => header;
            set { header = value; OnPropertyChanged(); }
        }

        string detail;
        public string Detail
        {
            get => detail;
            set { detail = value; OnPropertyChanged(); }
        }

        string solution;
        public string Solution
        {
            get => solution;
            set { solution = value; OnPropertyChanged(); }
        }



        #region Notify

        /// <summary>
        /// Property Changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Fire the PropertyChanged event
        /// </summary>
        /// <param name="propertyName">Name of the property that changed (defaults from CallerMemberName)</param>
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //PLEASE NOTE: if possible, inherit from Eagle.Core's NotifyBase instead of manually implementing it! //TODO: Implement INotifyPropertyChanged

        #endregion
    }
}
