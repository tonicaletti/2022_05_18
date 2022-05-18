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

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public delegate double Rechenoperation(double x, double y);
        
        public double ROP_plus(double x, double y)
        {
            return x + y;
        }

        public double ROP_mal(double x, double y)
        {
            return x * y;
        }

        public double ROP_minus(double x, double y)
        {
            return x -y;
        }

        public void exe(double x, double y, Rechenoperation rop)
        {
            textbox3.Text = rop(x, y).ToString();
        }

        public int i = 0;
        public MainWindow()
        {
            InitializeComponent();

            button_to_click.Click += method_calculate;
            

        }

        private void method_calculate(object sender, RoutedEventArgs e)
        {
            //if (op_plus.IsChecked == true)
            var x = Double.Parse(textbox1.Text);
            var y = Double.Parse(textbox2.Text);

            Rechenoperation delegate_OP = ROP_plus;

            if (op_plus.IsChecked == true)
                delegate_OP = ROP_plus;
            if (op_mal.IsChecked == true)
                delegate_OP = ROP_mal;
            if (op_minus.IsChecked == true)
                delegate_OP = ROP_minus;

            exe(x, y, delegate_OP);
        }
    }
}
