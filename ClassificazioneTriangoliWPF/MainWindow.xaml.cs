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

namespace ClassificazioneTriangoliWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtPrimoLato.Text != "" && txtSecondoLato.Text != "" && txtTerzoLato.Text != "")
            {
                try
                {
                    double PrimoLato = double.Parse(txtPrimoLato.Text);
                    double SecondoLato = double.Parse(txtSecondoLato.Text);
                    double TerzoLato = double.Parse(txtTerzoLato.Text);
                    if (PrimoLato == SecondoLato && PrimoLato == TerzoLato && SecondoLato == TerzoLato)
                    {
                        lblRisultato.Content = "Triangolo Equilatero";
                    }
                    else if (PrimoLato != SecondoLato || PrimoLato != TerzoLato || SecondoLato != TerzoLato)
                    {
                        lblRisultato.Content = "Triangolo Isoscele";
                    }
                    if (PrimoLato != SecondoLato && PrimoLato != TerzoLato && SecondoLato != TerzoLato)
                    {
                        lblRisultato.Content = "Triangolo Scaleno";
                    }
                    double perimetro = PrimoLato + SecondoLato + TerzoLato;
                    double area = (PrimoLato + SecondoLato + TerzoLato) / 2;
                    double area1 = Math.Sqrt(area *(area - PrimoLato) * (area - SecondoLato) * (area - TerzoLato));
                    lblArea.Content = area1;
                    lblPerimetro.Content = perimetro;
                }
                catch (Exception ex)
                {
                    lblRisultato.Content = ex.Message;
                }
            }
            else
            {
                MessageBox.Show("Inserisci tutti i lati", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
