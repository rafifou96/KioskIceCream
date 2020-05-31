using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
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
using BE;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace IceCreamKiosk.UserControls
{
    /// <summary>
    /// Logique d'interaction pour Shops.xaml
    /// </summary>
    public partial class Shops : UserControl
    {
        private List<Shop> shopsList;
        private List<Pushpin> pushpins;
        private BL.BL bl;
        
        public Shops()
        {
            InitializeComponent();

            InitialiseShopsList();
            InitialisePushpins();
            InitialiseMap();
        }

        private void InitialiseShopsList()
        {
            bl = BL.BL.GetInstance();
            shopsList = new List<Shop>(bl.GetAllShops());

            //shopsList = new ObservableCollection<Shop>
            //{
            //    new Shop { Name = "Tip Top Shop 1", Address = "Rue du Lt Jean Vigneux, Saint Gratien, France", Location = new Location { Latitude = 32, Longitude = 35.191130 }, Phone = "157", Website = "google.fr",     ImageURL="C:/Users/gabri/Pictures/m1.jpg", Supply = new ObservableCollection<IceCream> { new IceCream() } },
            //    new Shop { Name = "Tip Top Shop 2", Address = "Rue du Lt Jean Vigneux, Saint Gratien, France", Location = new Location { Latitude = 34, Longitude = 35.191132 }, Phone = "135", Website = "google.com",    ImageURL="C:/Users/gabri/Pictures/m1.jpg", Supply = new ObservableCollection<IceCream> { } },
            //    new Shop { Name = "Tip Top Shop 3", Address = "Rue du Lt Jean Vigneux, Saint Gratien, France", Location = new Location { Latitude = 36.765192, Longitude = 35.191134 }, Phone = "0123", Website = "google.co.it", ImageURL="C:/Users/gabri/Pictures/m1.jpg", Supply = new ObservableCollection<IceCream> { new IceCream(), new IceCream() } },
            //    new Shop { Name = "Tip Top Shop 4", Address = "Rue du Lt Jean Vigneux, Saint Gratien, France", Location = new Location { Latitude = 38.765192, Longitude = 35.191134 }, Phone = "0123", Website = "google.co.it", ImageURL="C:/Users/gabri/Pictures/m1.jpg", Supply = new ObservableCollection<IceCream> { new IceCream(), new IceCream() } }
            //};

            this.ListViewProducts.ItemsSource = shopsList;
        }

        private void InitialisePushpins()
        {
            pushpins = new List<Pushpin>();

            // Associates for each shop its pushpin
            foreach (var shop in shopsList)
            {
                var pushpinToAdd = new Pushpin { Location = shop.Location, Background = new SolidColorBrush(Colors.Yellow) };

                pushpinToAdd.MouseLeftButtonDown += PushpinToAdd_MouseLeftButtonDown;
                pushpins.Add(pushpinToAdd);
            }
        }

        private void InitialiseMap()
        {
            RefreshMap();

            if (shopsList.Count > 0)
                Map.Center = shopsList[0].Location;
            else
                Map.Center = new Location(31.765188, 35.191130); // JCT's Address ;)
        }

        private void RefreshMap()
        {
            this.Map.Children.Clear();
            foreach (var pushpin in pushpins)
            {
                this.Map.Children.Add(pushpin);
            }
        }

        private void PushpinToAdd_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var selectedPushpin = (Pushpin)sender;

            var correspondingShop = shopsList.Where(x => x.Location.Latitude == selectedPushpin.Location.Latitude
                                        && x.Location.Longitude == selectedPushpin.Location.Longitude).FirstOrDefault();
            DialogHost.DataContext = correspondingShop;

            DialogHost.IsOpen = true;
            Map.Center = selectedPushpin.Location;
        }

        private void Card_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var selectedShop = (sender as MaterialDesignThemes.Wpf.Card).DataContext as Shop;

            DialogHost.DataContext = selectedShop;
            DialogHost.IsOpen = true;
            Map.Center = selectedShop.Location;
        }
    }
}
