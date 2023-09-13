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
using DAISDAM.DB;
using DAISDAM.Models;
using DAISDAM.ViewModels;
using DAISDAM.Tools;

namespace DAISDAM
{
    /// <summary>
    /// Логика взаимодействия для AddPizza.xaml
    /// </summary>
    public partial class AddPizza : Window
    {
        public string Components { get; set; }

        public string Sousu { get; set; }
        public int Count { get; set; }
        public decimal Cost { get; set; }
        public AddPizza()
        {
            InitializeComponent();
            DataContext = this;
        }
        private void ListAdd(object sender,RoutedEventArgs e)
        {
            zxcContext context = new();
            Pizza i = new();
            i.Components = Components;
            i.Sousu = Sousu;
            i.Count = Count;
            i.Cost = Cost;
            context.Pizzas.Add(i);
            context.SaveChanges();


        }
    }
}
