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

namespace CalculadoraDinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {

            InitializeComponent();
            

            int contador = 0;

            for (int i = 2; i < 5; i++)
            {               
                for (int j = 0; j < 3; j++)
                {
                    Button b = new Button()
                    {
                        Tag = contador++,
                        Style = (Style)this.Resources["botones"]
                    };

                    Grid.SetColumn(b, j);
                    Grid.SetRow(b, i);

                    b.Click += Button_Click;
                    Viewbox view = new Viewbox();
                    Label label = new Label();
                    label.Content = contador;
                    view.Child = label;
                    b.Content = view;

                    contenedorGrid.Children.Add(b);
                    
                 
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String numero = (sender as Button).Tag.ToString();
            pantallaTextBlock.Text = pantallaTextBlock.Text + numero;
        }
    }
}
