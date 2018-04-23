using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace AdornerMessageBox {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window {
        public MainWindow() {
            InitializeComponent();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            MessageAdornerBox msgb = new MessageAdornerBox("Internet Connection Error",
                                         "There was a problem connecting to the internet, would you like to try again?",
                                         new SolidColorBrush(Colors.White),
                                         new SolidColorBrush(Colors.Black)) { FirstButtonCaption = "Yes", SecondButtonCaption = "No" };
            if (msgb.ShowDialog() == true)
                MessageBox.Show("Please try to reconnect later");
            //else
                //MessageBox.Show("False");
        }
    }
}
