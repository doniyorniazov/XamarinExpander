using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinExpander
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = this;
            InitializeComponent();

            Messages = new ObservableCollection<Message>();
            Messages.Add(new Message() { Header = "Close the main window.", Detail = "To be able to see this content you need to close the main window", Solution = "Press X button on the right corner or use shortcut Ctrl + SHift + C" });
            Messages.Add(new Message() { Header = "Close the main window.", Detail = "To be able to see this content you need to close the main window", Solution = "Press X button on the right corner or use shortcut Ctrl + SHift + C" });
            Messages.Add(new Message() { Header = "Close the main window.", Detail = "To be able to see this content you need to close the main window", Solution = "Press X button on the right corner or use shortcut Ctrl + SHift + C" });
            Messages.Add(new Message() { Header = "Close the main window.", Detail = "To be able to see this content you need to close the main window", Solution = "Press X button on the right corner or use shortcut Ctrl + SHift + C" });
            Messages.Add(new Message() { Header = "Close the main window.", Detail = "To be able to see this content you need to close the main window", Solution = "Press X button on the right corner or use shortcut Ctrl + SHift + C" });

     } 

        private ObservableCollection<Message> messages;

        public ObservableCollection<Message> Messages
        {
            get { return messages; }
            set { messages = value; OnPropertyChanged(); }
        }

        //#region Notify

        ///// <summary>
        ///// Property Changed event
        ///// </summary>
        //event PropertyChangedEventHandler PropertyChanged;

        ///// <summary>
        ///// Fire the PropertyChanged event
        ///// </summary>
        ///// <param name="propertyName">Name of the property that changed (defaults from CallerMemberName)</param>
        //void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
        //#endregion


    }
}
