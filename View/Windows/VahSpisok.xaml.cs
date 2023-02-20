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
    /// Логика взаимодействия для VahSpisok.xaml
    /// </summary>
    public partial class VahSpisok : Window
    {
        public VahSpisok()
        {
            InitializeComponent();
            GridVahSklad.ItemsSource = Appdata.ModelHelper.entities1.Sklad.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (ListViewItem eachItem in GridVahSklad.SelectedItems)
            {
                GridVahSklad.Items.Remove(eachItem);
            }

        }
    }
}
