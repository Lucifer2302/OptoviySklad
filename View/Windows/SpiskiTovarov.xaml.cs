using OptoviySklad.Model;
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
using System.Windows.Shapes;

namespace OptoviySklad.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для SpiskiTovarov.xaml
    /// </summary>
    public partial class SpiskiTovarov : Window
    {
        public SpiskiTovarov()
        {
            InitializeComponent();
            GridSklad.ItemsSource = Appdata.ModelHelper.entities1.Sklad.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }
    }
}
