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

namespace DNDbase
{
    /// <summary>
    /// Логика взаимодействия для HeroesWindow.xaml
    /// </summary>
    public partial class HeroesWindow : Window
    {
        List<Hero> heroes = new List<Hero>();
        public HeroesWindow()
        {
            InitializeComponent();

            heroes.Add(new Hero("Ivan Ivanov", "Эльф", "Друид"));
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            listBoxHeroes.ItemsSource = null;
            listBoxHeroes.ItemsSource = heroes;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            if (window.ShowDialog().Value)
            {
                heroes.Add(window.NewHero);
                RefreshListBox();
            }
        }

        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxHeroes.SelectedIndex != -1)
            {
                heroes.RemoveAt(listBoxHeroes.SelectedIndex);
                RefreshListBox();
            }
        }
    }
}
