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

namespace DNDbase
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() { 
            InitializeComponent();
        }
   
        Hero _newHero;

        public Hero NewHero
        {
            get
            {
                return _newHero;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Необходимо ввести фамилию");
                textBoxName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxRace.Text))
            {
                MessageBox.Show("Необходимо ввести расу");
                textBoxRace.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxAspect.Text))
            {
                MessageBox.Show("Необходимо ввести класс");
                textBoxAspect.Focus();
                return;
            }

            _newHero = new Hero(textBoxName.Text, textBoxRace.Text, textBoxAspect.Text);
            DialogResult = true;
        }
    
    }
}
