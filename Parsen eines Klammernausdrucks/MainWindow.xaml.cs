using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
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

namespace Parsen_eines_Klammernausdrucks
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack stack = new Stack();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, RoutedEventArgs e)
        {
            Parse parse = new Parse();
            if (parse.ParseCharSet(txtInput.Text.ToCharArray()))
                txtParse.Text = "Die Klammersetztung ist Korreckt";
            else
                txtParse.Text = "Die Klammersetztung ist Fehlerhaft";
        }  
    }
}
