using BE;
using BL;
using Microsoft.Maps.MapControl.WPF;
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
    /// Logique d'interaction pour Search.xaml
    /// </summary>
    public partial class Search : UserControl
    {
        private BL.BL bL = BL.BL.GetInstance();
        private List<IceCream> iceCreamList, searchList;

       
        public Search()
        {
            InitializeComponent();

            InitializeLists();
            InitialiseCombobox();
            this.ListViewIceCreams.ItemsSource = searchList;
        }

        #region Initialisation
        private void InitializeLists()
        {
            iceCreamList = new List<IceCream>(bL.GetAllIceCreams());

            // At the start, searchList equals to iceCreamList
            searchList = iceCreamList;
        }

        private void InitialiseCombobox()
        {
            List<string> choicesComboboxList = new List<string> { "Name", "Lowest Rate", "Highest Rate", "Energy", "Protein", "Fat" };
            ComboboxSort.ItemsSource = choicesComboboxList;
        }
        #endregion

        private void ComboboxSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            searchList = iceCreamList;

            switch (ComboboxSort.SelectedIndex)
            {
                case 0:
                    searchList = searchList.OrderBy(x => x.Name).ToList();
                    break;

                case 1:
                    var minRate = searchList.OrderBy(x => x.AverageRate).FirstOrDefault();
                    searchList = new List<IceCream> { minRate };
                    break;

                case 2:
                    var maxRate = searchList.OrderByDescending(x => x.AverageRate).FirstOrDefault();
                    searchList = new List<IceCream> { maxRate };
                    break;

                case 3:
                    searchList = searchList.OrderBy(x => x.Energy).ToList();
                    break;

                case 4:
                    searchList = searchList.OrderBy(x => x.Sugar).ToList();
                    break;

                case 5:
                    searchList = searchList.OrderBy(x => x.Fat).ToList();
                    break;

                default: break;
            }

            this.ListViewIceCreams.ItemsSource = searchList;
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string searchQuery = textBox.Text.ToLower();

            if (string.IsNullOrEmpty(textBox.Text))
            {
                searchList = iceCreamList;
                ComboboxSort.SelectedIndex = 0;
            }
            else
            {
                // We're looking into Name, Flavour and Decription fields
                searchList = iceCreamList.Where(x => !string.IsNullOrEmpty(x.Flavour) && !string.IsNullOrEmpty(x.Description) &&
                                                     !string.IsNullOrEmpty(x.Name)
                                                     && x.Flavour.ToLower().Contains(searchQuery)
                                                     || x.Description.ToLower().Contains(searchQuery)
                                                     || x.Name.ToLower().Contains(searchQuery)).ToList();
            }

            this.ListViewIceCreams.ItemsSource = searchList;
        }

        private void Card_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Opening DialogHost with the relevant Ice-Cream
            var selectedIceCream = (sender as MaterialDesignThemes.Wpf.Card).DataContext as IceCream;
            DialogHost.DataContext = selectedIceCream;
            DialogHost.IsOpen = true;

            // Updating Map in the DialogHost
            Map.Children.Clear();
            Map.Center = selectedIceCream.Shop.Location;
            Map.Children.Add(new Pushpin { Location = selectedIceCream.Shop.Location, Background = Brushes.Yellow });
        }
    }
}