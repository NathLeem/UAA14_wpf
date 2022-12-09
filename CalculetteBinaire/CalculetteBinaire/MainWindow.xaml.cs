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

namespace CalculetteBinaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbNbr1.PreviewTextInput += new TextCompositionEventHandler(VerifTexte);

            RemplirTableau();
        }

        public string VerifTexte()
        {
            string nombreBinaire = "";

            return nombreBinaire;
        }
        public void RemplirTableau()
        {
            ushort[] tabBin;
        }
    }
}
