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
    /// Логика взаимодействия для SbrosParolya1.xaml
    /// </summary>
    public partial class SbrosParolya1 : Window
    {
        public SbrosParolya1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var v = Appdata.ModelHelper.entities1.Profile.Where(i => i.Email == EmailTb.Text).FirstOrDefault();
            if (v == null)
            {
                MessageBox.Show("Такой почты нет");
            }
            if (v != null)
            {
                MessageBox.Show("Успех");
                SbrosParolya2 sbrosParolya2= new SbrosParolya2();
                sbrosParolya2.Show();
                this.Close();
            }



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
            this.Close();
        }
    }
}
