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

namespace ej1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rd1 = new Random();
        private int numSecreto;
        public MainWindow()
        {
            InitializeComponent();
            numSecreto = rd1.Next(1, 101);
        }

        private void comprobarButtonClick(object sender, RoutedEventArgs e)
        {
            if (numSecreto > int.Parse(nombreTextBlock.Text))
            {
                pistaTextBlock.Text = "Te has quedado corto";
            }
            if (numSecreto < int.Parse(nombreTextBlock.Text))
                pistaTextBlock.Text = "Te has pasado";
            if (numSecreto == int.Parse(nombreTextBlock.Text))
                pistaTextBlock.Text = "Has acertado!!";
        }

        private void reiniciarButtonClick(object sender, RoutedEventArgs e)
        {
            numSecreto = rd1.Next(1, 101);
            nombreTextBlock.Text = "";
            pistaTextBlock.Text = "";
        }
    }
}
