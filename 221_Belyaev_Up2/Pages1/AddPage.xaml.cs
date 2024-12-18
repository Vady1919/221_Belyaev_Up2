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

namespace _221_Belyaev_Up2.Pages1
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        private Partners _currentPartners = new Partners();
        public AddPage(Partners selectedPartners)
        {
            InitializeComponent();
            Type.ItemsSource = Belyaev_UP2Entities.GetContext().PartnersType.ToList();
            if (selectedPartners != null)
                _currentPartners = selectedPartners;

            DataContext = _currentPartners;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (Rating.Text != "")
            {
                try
                {
                    _currentPartners.Rating = int.Parse(Rating.Text);
                    if (int.Parse(Rating.Text) < 0) errors.AppendLine("Рейтинг не может быть отрицательным!");
                }
                catch (Exception)
                {
                    errors.AppendLine("Некорректное значение рейтинга!");
                }
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            else
                if (_currentPartners.PartnerID == 0)
                Belyaev_UP2Entities.GetContext().Partners.Add(_currentPartners);
            try
            {
                Belyaev_UP2Entities.GetContext().SaveChanges();
                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
