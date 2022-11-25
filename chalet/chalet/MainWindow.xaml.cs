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

namespace chalet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtNbPers.PreviewTextInput += new TextCompositionEventHandler(VerifEntier);
            txtDateStart.PreviewTextInput += new TextCompositionEventHandler(VerifDate);
            txtDateEnd.PreviewTextInput += new TextCompositionEventHandler(VerifDate);
            btnCalcul.Click += new RoutedEventHandler();
            btnInit.Click += new RoutedEventHandler();
            btnSortie.Click += new RoutedEventHandler();
            rdChalet.Checked += new RoutedEventHandler();
            rdTente.Checked += new RoutedEventHandler();
            boxReserv.Checked += new RoutedEventHandler();
        }

        public void VerifEntier(object sender, TextCompositionEventArgs e)
        {
            int entier;

            if (int.TryParse(e.Text,out entier))
            {
                entier = int.TryParse(e.Text);
            }
        }
        public void VerifDate(object sender, TextCompositionEventArgs e)
        {
            if ()
            {

            }
        }
    }
}
