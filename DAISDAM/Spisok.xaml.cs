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
using System.Windows.Shapes;
using DAISDAM.ViewModels;

    namespace DAISDAM
{
    /// <summary>
    /// Логика взаимодействия для Spisok.xaml
    /// </summary>
    public partial class Spisok : Window
    {
        public Spisok()
        {
            InitializeComponent();
            DataContext = new AddVM();
        }
        private void  Update(object sender,RoutedEventArgs e)
        {
            Spisok newWin = new Spisok();
            newWin.Show();
            this.Close();
        }
        private void Add(object sender, RoutedEventArgs e)
        {
            AddPizza addPizza = new AddPizza();
            addPizza.Show();
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }


    }
}
