using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAISDAM.DB;
using DAISDAM.Models;
using DAISDAM.ViewModels;
using DAISDAM.Tools;
using System.Windows;

namespace DAISDAM.ViewModels
{
    public class AddVM
    {
        public List<Pizza> Pizzas { get; set; }
        public Pizza SelectedPizza { get; set; }
        public Pizza pizzas { get; set; }

        public CommandVM Delete { get; set; }

        public string Title { get; set; }

        public int Count { get; set; }
        public CommandVM Add { get; set; }

        public AddVM()
        {
            Pizzas = zxcContext.GetInstance().Pizzas.ToList();
            Delete = new CommandVM(() =>
            {
                try
                {
                    zxcContext.GetInstance().Pizzas.Remove(SelectedPizza);
                    zxcContext.GetInstance().SaveChanges();
                    MessageBox.Show("Удалилось!");
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }

            });
                
                
                
                
               
        }
    }
}
