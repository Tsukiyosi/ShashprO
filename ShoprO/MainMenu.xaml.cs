﻿using System;
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
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
       
        public MainMenu(string name)
        {
            InitializeComponent();

            
            HelloLbl.Content = ("Hello, " + name + " let`s play Shashki");
        }

        private void SinglPl_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Game());
        }

       

        private void Seting_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Settings());
        }
    }
}
