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
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        string name { get; set; }
        public Settings()
        {
            InitializeComponent();

            List<string> styles = new List<string> { "StandartTheme" };
            ThemesSelect.SelectionChanged += ThemeChange;
            ThemesSelect.ItemsSource = styles;
            ThemesSelect.SelectedItem = "StandartTheme";
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = ThemesSelect.SelectedItem as string;
            
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
           
            Application.Current.Resources.Clear();
            
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            ThemesSelect.SelectionChanged += ThemeChange;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenu(name));
        }
    }
}
