using OptoviySklad.Appdata;
using OptoviySklad.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace OptoviySklad
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string log = "";
            if (string.IsNullOrWhiteSpace(LoginTB.Text))
                log += "Введите логин\n";

            if (string.IsNullOrWhiteSpace(PassTB.Password))
                log += "Введите пароль\n";

            if (string.IsNullOrWhiteSpace(EmTb.Text))
                log += "Введите почту\n";


            if (log != "")
            {
                MessageBox.Show(log);
                log = "";
                return;
            }
            Model.Profile profile = new Model.Profile()
            {
                Login = LoginTB.Text,
                Password = PassTB.Password,
                Email = EmTb.Text
            };
            ModelHelper.entities1.Profile.Add(profile);
            ModelHelper.entities1.SaveChanges();
            MessageBox.Show("Учетная запись создана");
            LoginTB.Text = "";

            Profile profile1 = new Profile();
            profile1.Show();
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Vxod vxod = new Vxod();
            vxod.Show();
            this.Close();
        }
    }
}
