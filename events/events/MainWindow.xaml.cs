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

namespace events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TxtA.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TxtB.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            TxtC.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            btnCalcule.MouseEnter += new MouseEventHandler(SurvolBtn);
            btnCalcule.MouseLeave += new MouseEventHandler(QuitteBtn);
        }

        public void VerifTextInput(object sender,TextCompositionEventArgs e)
        {
            if (e.Text != "," && !EstEntier(e.Text))
            {
                e.Handled = true;
            }
            if (((TextBox)sender).Text.IndexOf(e.Text)>-1)
            {
                
            }
        }

        private bool EstEntier(string texteUser)
        {
            int text;
            bool entier = false;
            
            if (int.TryParse(texteUser, out text))
            {
                entier = true;
            }
            return entier;
        }

        public void SurvolBtn(object sender ,MouseEventArgs e)
        {
            btnV.Visibility = Visibility.Visible;
            btnV.Background = Brushes.Red;
        }
        public void QuitteBtn(object sender ,MouseEventArgs e)
        {
            btnV.Visibility = Visibility.Hidden;
        }
    }
}