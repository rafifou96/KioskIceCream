using BE;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour AdminAuth.xaml
    /// </summary>
    public partial class AdminAuth : UserControl
    {
        private BL.BL bL = BL.BL.GetInstance();
        private Shop currentShop;

        public AdminAuth()
        {
            InitializeComponent();
            
            currentShop = new Shop();
            DataContext = currentShop;

            ResetDialogHost();
            gridSignUp.Visibility = Visibility.Hidden;
            gridLogin.Visibility = Visibility.Visible;
        }

        private void ResetDialogHost()
        {
            dialTextBlock.Text = "You must fill the whole of the fields.";
            dialTextBlock.Inlines.Add(new LineBreak());
            dialTextBlock.Inlines.Add(new LineBreak());
        }


        #region Check Function
        private bool CheckAndPrintLoginDialog()
        {
            ResetDialogHost();
            int fieldsNonAcceptable = 0;

            if (string.IsNullOrEmpty(txtLoginEmail.Text))
            {
                dialTextBlock.Inlines.Add(new Run("Email") { FontWeight = FontWeights.Bold });
                ++fieldsNonAcceptable;
            }

            if (string.IsNullOrEmpty(psLoginPassword.Password))
            {
                if (fieldsNonAcceptable > 0)
                    dialTextBlock.Inlines.Add(new LineBreak());
                dialTextBlock.Inlines.Add(new Run("Password") { FontWeight = FontWeights.Bold });
                ++fieldsNonAcceptable;
            }

            return fieldsNonAcceptable == 0;
        }

        private bool CheckAndPrintSignUpDialog()
        {
            ResetDialogHost();
            int fieldsNonAcceptable = 0;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                dialTextBlock.Inlines.Add(new Run("Shop's Name") { FontWeight = FontWeights.Bold });
                ++fieldsNonAcceptable;
            }

            if (string.IsNullOrEmpty(txtPseudo.Text))
            {
                if (fieldsNonAcceptable > 0)
                    dialTextBlock.Inlines.Add(new LineBreak());
                dialTextBlock.Inlines.Add(new Run("Pseudo") { FontWeight = FontWeights.Bold });
                ++fieldsNonAcceptable;
            }

            if (string.IsNullOrEmpty(psPassword.Password))
            {
                if (fieldsNonAcceptable > 0)
                    dialTextBlock.Inlines.Add(new LineBreak());
                dialTextBlock.Inlines.Add(new Run("Password") { FontWeight = FontWeights.Bold });
                ++fieldsNonAcceptable;
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                if (fieldsNonAcceptable > 0)
                    dialTextBlock.Inlines.Add(new LineBreak());
                dialTextBlock.Inlines.Add(new Run("Address") { FontWeight = FontWeights.Bold });
                ++fieldsNonAcceptable;
            }

            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                if (fieldsNonAcceptable > 0)
                    dialTextBlock.Inlines.Add(new LineBreak());
                dialTextBlock.Inlines.Add(new Run("Phone Number") { FontWeight = FontWeights.Bold });
                ++fieldsNonAcceptable;
            }

            if (string.IsNullOrEmpty(txtWebsite.Text))
            {
                if (fieldsNonAcceptable > 0)
                    dialTextBlock.Inlines.Add(new LineBreak());
                dialTextBlock.Inlines.Add(new Run("Website") { FontWeight = FontWeights.Bold });
                ++fieldsNonAcceptable;
            }

            if (imgAddImageBkg.Source == null)
            {
                if (fieldsNonAcceptable > 0)
                    dialTextBlock.Inlines.Add(new LineBreak());
                dialTextBlock.Inlines.Add(new Run("Devanture Picture") { FontWeight = FontWeights.Bold });
                ++fieldsNonAcceptable;
            }

            return fieldsNonAcceptable == 0;
        }
        #endregion


        #region Click Events
        private void btnAddPicture_Click(object sender, RoutedEventArgs e)
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
                imgAddImageBkg.Source = new BitmapImage(new Uri(op.FileName));
                txtBtnAddPicture.Visibility = Visibility.Hidden;
            }
        }

        private void btnToSignUpPage_Click(object sender, RoutedEventArgs e)
        {
            gridLogin.Visibility = Visibility.Hidden;
            gridSignUp.Visibility = Visibility.Visible;

            currentShop = new Shop();
            DataContext = currentShop;
        }

        private void btnToLoginPage_Click(object sender, RoutedEventArgs e)
        {
            gridSignUp.Visibility = Visibility.Hidden;
            gridLogin.Visibility = Visibility.Visible;

            currentShop = new Shop();
            DataContext = currentShop;
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            pgbLogin.Visibility = Visibility.Visible;
            var allFieldsFilled = CheckAndPrintLoginDialog();

            if (!allFieldsFilled)
                DialogHost.IsOpen = true;
            else
            {
                currentShop.Password = psLoginPassword.Password;
                var list = bL.GetAllShops()
                        .Where(x => x.Pseudo == currentShop.Pseudo && x.Password == currentShop.Password);

                if (list.Count() != 0)
                {
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new AdminDashboard(list.Last()));
                }
                else
                {
                    MessageBox.Show("Any User is associated to this account. Please sign-up");
                    pgbLogin.Visibility = Visibility.Hidden;
                }
            }
        }

        private async void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            pgbLogin.Visibility = Visibility.Visible;
            var allFieldsFilled = CheckAndPrintSignUpDialog();

            if (!allFieldsFilled)
                DialogHost.IsOpen = true;
            else
            {
                currentShop.Password = psPassword.Password;


                await BL.BL.GetInstance().AddShop(currentShop);
                GridMain.Children.Clear();
                GridMain.Children.Add(new AdminDashboard(currentShop));
            }
        }
        #endregion


        private async void txtAddress_LostFocus(object sender, RoutedEventArgs e)
        {
            string address = txtAddress.Text;
            if (!(string.IsNullOrEmpty(address)))
            {
                pgbAddress.Visibility = Visibility.Visible;
                currentShop.Location = new Location();

                (double lat, double lng) = (currentShop.Location.Latitude, currentShop.Location.Longitude);
                try
                {
                    (lat, lng) = await Services.LocationHelper.GetLatLong(address);

                }
                catch (Exception) { }

                currentShop.Location = new Microsoft.Maps.MapControl.WPF.Location(lat, lng);

                //MessageBox.Show($"{lat} {lng}");
                pgbAddress.Visibility = Visibility.Hidden;
            }
        }

    }
}
