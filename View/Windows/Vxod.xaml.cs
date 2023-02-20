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
    /// Логика взаимодействия для Vxod.xaml
    /// </summary>
    public partial class Vxod : Window
    {
        public Vxod()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var v = Appdata.ModelHelper.entities1.Profile.Where(i => i.Login == LoginTB.Text ).FirstOrDefault();
            var vb = Appdata.ModelHelper.entities1.Profile.Where(i => i.Password == PassTB.Password).FirstOrDefault();
            if (v == null)
            {
                MessageBox.Show("Такого пользователя нет");
                logL.Foreground = Brushes.Red;
            };

            if (vb == null)
            {
                MessageBox.Show("Неверный пароль");
                PassL.Foreground = Brushes.Red;
            };




            if (v != null && vb != null)
            {
                MessageBox.Show("Добро пожаловать");
                Profile profile1 = new Profile();
                profile1.Show();
                this.Close();
            }



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SbrosParolya1 sbrosParolya1 = new SbrosParolya1();
            sbrosParolya1.Show();
            this.Close();
        }
    }
}
