using BE;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IceCreamKiosk.UserControls
{
    /// <summary>
    /// Logique d'interaction pour AdminDashboard.xaml
    /// </summary>
    public partial class AdminDashboard : UserControl
    {
        private static Shop currentShop;
        private BL.BL bL = BL.BL.GetInstance();

        private ObservableCollection<IceCream> iceCreamList;
        private Rating currentRating;
        private IceCream currentIceCream, chosenIceCream;

        public AdminDashboard(Shop connectedShop)
        {
            InitializeComponent();

            SetCurrentShop(connectedShop);
            InitialiseShop();
        }

        public static void SetCurrentShop(Shop connectedShop)
        {
            currentShop = connectedShop;

            if (currentShop == null)
                currentShop = new Shop
                {
                    Name = "Test",
                    Address = "Rue des espions",
                    ImageURL = "C:/Users/gabri/Pictures/m1.jpg",
                    Location = new Location(31, 31),
                    Phone = "053",
                    Website = "sue.fr"
                };
        }

        private void InitialiseShop()
        {
            iceCreamList = new ObservableCollection<IceCream>(currentShop.Supply);
            
            currentRating = new Rating { Rate = 4 };
            currentIceCream = new IceCream();

            this.DataContext = currentShop;
            stkpAddIceCream.DataContext = currentIceCream;

            ListViewIceCreams.ItemsSource = iceCreamList;

            gdDialogHost.DataContext = currentIceCream;

            stkpOffer.DataContext = iceCreamList;

            Map.Center = currentShop.Location;
            Map.Children.Add(new Pushpin { Location = currentShop.Location, Background = new SolidColorBrush(Colors.Yellow) });
        }

        private async void txtTaste_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtTaste.Text)))
            {
                LoadingMode();

                try
                {
                    (currentIceCream.Energy, currentIceCream.Fat, currentIceCream.Sugar) = await Services.NutritionalHelper.GetNutritionalInfo(txtTaste.Text);
                }
                catch (Exception)
                { }

                FinishedMode();

                txtEnergy.Text = $"{Math.Round((double)currentIceCream.Energy,1)} KCAL";
                txtSugar.Text = $"{Math.Round((double)currentIceCream.Sugar,1)} g";
                txtFat.Text = $"{Math.Round((double)currentIceCream.Fat,1)} g";
            }
        }

        private async void btnAddPicture_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog
            {
                Title = "Select An Ice-Cream Picture",
                Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                         "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                         "Portable Network Graphic (*.png)|*.png"
            };

            if (op.ShowDialog() == true)
            {
                txtBtnAddPicture.Visibility = Visibility.Hidden;
                pgbImage.Visibility = Visibility.Visible;
                btnAdd.IsEnabled = false;

                imgAddImageBkg.Source = new BitmapImage(new Uri(op.FileName));

                bool OK = await Services.ImageAnalyzer.ImageAnalyser(op.FileName);

                if (OK)
                {
                    btnAddPicture.BorderBrush = Brushes.Green;
                    btnAdd.IsEnabled = true;
                    currentIceCream.ImageURL = op.FileName;
                }
                else
                {
                    btnAddPicture.BorderBrush = Brushes.Red;
                    btnAdd.IsEnabled = false;
                }

                pgbImage.Visibility = Visibility.Hidden;
            }
        }

        private async void txtChangeAddress_LostFocus(object sender, RoutedEventArgs e)
        {
            string address = txtChangeAddress.Text;
            if (!(string.IsNullOrEmpty(address)))
            {
                (double lat, double lng) = await Services.LocationHelper.GetLatLong(address);

                currentShop.Location = new Location(lat, lng);

                Map.Children.Clear();
                Map.Center = currentShop.Location;
                Map.Children.Add(new Pushpin { Location = currentShop.Location, Background = new SolidColorBrush(Colors.Yellow) });

                await bL.UpdateShop(currentShop);
            }
        }

        private async void btnDialogDelete_Click(object sender, RoutedEventArgs e)
        {
            iceCreamList.Remove(chosenIceCream);
            currentShop.Supply.Remove(chosenIceCream);

            await bL.UpdateShop(currentShop);

            DialogHost.IsOpen = false;   
        }


        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            iceCreamList.Add(currentIceCream);
            currentIceCream.Shop = currentShop;

            await bL.UpdateIceCream(currentIceCream);

            currentIceCream = new IceCream();
            stkpAddIceCream.DataContext = currentIceCream;

            txtBtnAddPicture.Visibility = Visibility.Visible;
            pgbImage.Visibility = Visibility.Hidden;
            btnAdd.IsEnabled = false;
            
            imgAddImageBkg.Source = null;
            btnAddPicture.BorderThickness = new Thickness(1);
            btnAddPicture.BorderBrush = Brushes.Purple;
        }

        private void btnShowIceCream_Click(object sender, RoutedEventArgs e)
        {
            chosenIceCream = (sender as Button).DataContext as IceCream;
            gdDialogHost.DataContext = chosenIceCream;
            DialogHost.IsOpen = true;
        }

        private async void btnChangePicture_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog
            {
                Title = "Select a Devanture Picture of Your Shop",
                Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
               "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
               "Portable Network Graphic (*.png)|*.png"
            };

            if (op.ShowDialog() == true)
            {
                currentShop.ImageURL = op.FileName;
                await bL.UpdateShop(currentShop);

                imgBtnDevanture.Source = new BitmapImage(new Uri(op.FileName));
                imgBtnDevantureBack.Source = new BitmapImage(new Uri(op.FileName));
                flpChangeNamePicture.IsFlipped = false;
            }
        }


        void LoadingMode()
        {
            stkpNutritionalInfos.Opacity = 0.3;
            pgbNutritionalInfos.Visibility = Visibility.Visible;
        }

        private void Disconnection_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Clear();
            GridMain.Children.Add(new AdminAuth());
        }

        private async void txtFlpChangeName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtFlpChangeName.Text)))
            await bL.UpdateShop(currentShop);
        }

        private async void txtFlpChangePhone_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtFlpChangePhone.Text)))
                await bL.UpdateShop(currentShop);
        }

        private async void txtFlpWebsite_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtFlpWebsite.Text)))
                await bL.UpdateShop(currentShop);
        }

        void FinishedMode()
        {
            stkpNutritionalInfos.Opacity = 1;
            pgbNutritionalInfos.Visibility = Visibility.Hidden;
        }
    }
}
