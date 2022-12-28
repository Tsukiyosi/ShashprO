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
using Microsoft.EntityFrameworkCore;
using System.Windows.Shapes;

namespace ShoprO
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    /// 

    class PlayerException : Exception
    {
        public PlayerException(string message)
        : base(message) { }
    }
    public partial class Login : Page
    {
        public Player Player { get; private set; }

        string name { get; set; }

        private void Themes()
        {
            var uri = new Uri("StandartTheme.xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void CheckPass()
        {
            Player player = new Player();
            if (player.password == Pass.Text)
                throw new PlayerException("Your Password is not correct");
        }

        private void CheckLogin()
        {
            Player player = new Player();
            if (player.login == lgn.Text)
                throw new PlayerException("Your Login is not correct or you`r not sign up");
        }

        public Login()
        {
            Player player = new Player();
            InitializeComponent();
            Themes();
            name = player.login;
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            
            name = lgn.Text;
            try
            {
                CheckLogin();
                CheckPass();
            }
            catch (PlayerException ex)
            {
                toplbl.Content = ex.Message;
            }
            finally
            {
                
                NavigationService.Navigate(new MainMenu(name));
            }
            
        }

        private void Registr_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Registration(Player));
        }
    }
}
