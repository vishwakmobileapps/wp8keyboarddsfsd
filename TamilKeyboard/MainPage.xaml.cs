using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TamilKeyboard.Resources;
using Windows.ApplicationModel.DataTransfer;
using System.Windows.Media;


namespace TamilKeyboard
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

          //  txtvalue.GotFocus +=txtvalue_GotFocus;
           txtvalue.LostFocus +=txtvalue_LostFocus;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        

        private void txtvalue_LostFocus(object sender, RoutedEventArgs e)
        {
           // this.Focus();
            btn51.Visibility = Visibility.Visible;
        }

        private void txtvalue_GotFocus(object sender, RoutedEventArgs e)
        {
           // txtvalue.Background = new SolidColorBrush(Colors.White);
          // btn51.Visibility = Visibility.Collapsed;

        }

        private void btn01_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                txtvalue.Text = txtvalue.Text + ((TextBlock)sender).Text.ToString().Trim();
                btn51.Visibility = Visibility.Visible;
              //  txtvalue.Foreground = new SolidColorBrush(Colors.Black);
            }
            catch(Exception ex)
            {
            }
        }


        private void btn48_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
              //  txtvalue.Foreground = new SolidColorBrush(Colors.Black);
                txtvalue.Text = txtvalue.Text.Remove(txtvalue.Text.Length - 1, 1);
                btn51.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
            }
        }

        private void btn49_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
              //  txtvalue.Foreground = new SolidColorBrush(Colors.Black);
                txtvalue.Text = txtvalue.Text + " ";
                btn51.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
            }

        }


        private void btneng_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
              //  txtvalue.Foreground = new SolidColorBrush(Colors.Black);
                txtvalue.Focus();
                btn51.Visibility = Visibility.Visible;
                txtvalue.Select(txtvalue.Text.Length, 0);

               

            }
            catch (Exception ex)
            {
            }

        }

        private void btncopy_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                txtvalue.Focus();
                btn51.Visibility = Visibility.Collapsed;
                Clipboard.SetText(txtvalue.Text);
                //txtvalue.SelectionBackground = new SolidColorBrush(Colors.Blue) ;
               // txtvalue.SelectionStart = 0;
               // txtvalue.SelectionLength = txtvalue.Text.Length;
                txtvalue.SelectAll();
              // txtvalue.SelectionBackground = new SolidColorBrush(Colors.Blue) ;
             //  txtvalue.Foreground = new SolidColorBrush(Colors.Blue);
              //  txtvalue.SelectionForeground = new SolidColorBrush(Colors.Red);
                //txtvalue.Select(txtvalue.Text.Length, 0);

               
            }
            catch (Exception ex)
            {
            }

        }

       

        private void btnpaste_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            try
            {
                if (Clipboard.ContainsText())
                {
                    txtvalue.Text = Clipboard.GetText();
                }
            }
            catch (Exception ex)
            {
            }

        }



        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}