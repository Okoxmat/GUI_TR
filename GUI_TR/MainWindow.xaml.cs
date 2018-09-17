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
using System.Data;


namespace GUI_TR
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {


        string leer;
        string Rechnungstring;
        string Ergebnis;
        public MainWindow()
        {
            InitializeComponent();
        }

        

        public void Button_1(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text += "1";

        }

        public void Button_2(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text += "2";
        }

        public void Button_3(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text += "3";
        }

        public void Button_4(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text += "4";
        }

        public void Button_5(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text += "5";
        }

        public void Button_6(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text += "6";
        }

        public void Button_7(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text += "7";
        }

        public void Button_8(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text += "8";
        }

        public void Button_9(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text += "9";
        }

        public void Button_0(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text += "0";
        }

        public void Button_add(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text += "+";
        }

        public void Button_sub(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text += "-";
        }

        public void Button_mul(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text += "*";
        }

        public void Button_div(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text += "/";
        }

        public void Button_res(object sender, RoutedEventArgs e)
        {
            //Holt sich den Text aus der Eingabe zu var "Rechnugnsstring"
            Rechnungstring = this.Eingabefeld.Text;
            Ergebnis = MathParser.EvalExpression(Rechnungstring.ToCharArray()).ToString();
            MessageBox.Show(Rechnungstring);
            this.ErgebnisFeld.Text = Ergebnis;
        }                                                                                                                              

        private void Button_leeren(object sender, RoutedEventArgs e)
        {
            this.Eingabefeld.Text = leer;
            this.ErgebnisFeld.Text = leer;
        }
    }
}
