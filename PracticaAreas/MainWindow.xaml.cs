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

namespace PracticaAreas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnR_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(txtBaseR.Text);
            double num2 = double.Parse(txtAlturaR.Text);
            double resultado = num1 * num2;
            lblR.Text = resultado.ToString();
        }

        private void BtnT_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(txtBaseT.Text);
            double num2 = double.Parse(txtAlturaT.Text);
            double resultado = (num1 * num2)/ 2 ;
            lblT.Text = resultado.ToString();
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            double num1 = int.Parse(txtRadioC.Text);
            double num2 = Math.PI;
            double resultado = (num1 * num1)* num2;
            lblC.Text = resultado.ToString();
        }

        private void BtnTa_Click(object sender, RoutedEventArgs e)
        {
            double num1 = double.Parse(txtBaseMayorTa.Text);
            double num2 = double.Parse(txtBaseMenorTa.Text);
            double num3 = double.Parse(txtAlturaTa.Text);
            double resultado = num3 * ((num1 + num2) / 2);
            lblTa.Text = resultado.ToString();
        }

    }
}
