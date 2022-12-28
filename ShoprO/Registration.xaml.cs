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

namespace ShoprO
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Player Player { get; private set; }
        public Registration(Player player)
        {
            InitializeComponent();
            Player = player;
            DataContext = Player;
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            
            Player.login = RegLog.Text;
            Player.password = Convert.ToInt32(RegPass.Text);
            

        }
    }
}
