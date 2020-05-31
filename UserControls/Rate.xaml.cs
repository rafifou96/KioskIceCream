using BE;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace IceCreamKiosk.UserControls
{
    /// <summary>
    /// Logique d'interaction pour Rate.xaml
    /// </summary>
    public partial class Rate : UserControl
    {
        private BL.BL bL = BL.BL.GetInstance();

        private ObservableCollection<IceCream> iceCreamList;
        private IceCream selectedIceCream = null;
        private Rating currentRating;

        public Rate()
        {
            InitializeComponent();

            InitialiseLists();
        }

        private void InitialiseLists()
        {
            iceCreamList = bL.GetAllIceCreams();

            this.ListViewIceCreams.ItemsSource = iceCreamList;

            currentRating = new Rating();
            stkpRating.DataContext = currentRating;
        }

        private void CardIceCream_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            selectedIceCream = (sender as MaterialDesignThemes.Wpf.Card).DataContext as IceCream;
            pnlBeforeIceCream.Visibility = Visibility.Hidden;

            UpdateIceCreamSelected();
        }

        private void UpdateIceCreamSelected()
        {
            this.ListViewIceCreamsRatings.ItemsSource = selectedIceCream.Ratings;
            stkpIceCreamInfos.DataContext = selectedIceCream;
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
                bool OK = await Services.ImageAnalyzer.ImageAnalyser(op.FileName);

                if (OK)
                {
                    currentRating.ImageURL = op.FileName;

                    btnAddPicture.Background = Brushes.Green;
                    btnAddRate.IsEnabled = true;
                }
                else
                {
                    btnAddRate.IsEnabled = false;
                    btnAddPicture.Background = Brushes.Red;
                }
            }
        }

        private async void btnAddRate_Click(object sender, RoutedEventArgs e)
        {
            currentRating.Rate = ratingBar.Value;

            selectedIceCream.Ratings.Add(currentRating);
            selectedIceCream.AverageRate = selectedIceCream.Ratings.Average(x => x.Rate);
            
            await bL.UpdateIceCream(selectedIceCream);

            ListViewIceCreamsRatings.ItemsSource = null;
            UpdateIceCreamSelected();

            ratingBar.Value = 0;
            txtAverageRate.Text = Math.Round(selectedIceCream.AverageRate, 1).ToString();

            currentRating = new Rating();
            stkpRating.DataContext = currentRating;
            btnAddPicture.Background = Brushes.Purple;
        }
    }
}
