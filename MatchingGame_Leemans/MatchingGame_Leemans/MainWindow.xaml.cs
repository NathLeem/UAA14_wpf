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
using System.Windows.Threading;

namespace MatchingGame_Leemans
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random nbAlea = new Random();
        int index = 0;
        string nextEmoji = "";
        DispatcherTimer timer = new DispatcherTimer();
        int tempsEcoule = 0;
        int nbPairesTrouvees = 0;

        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
            timer.Start();
            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += EventHandler(Timer_Tick);
        }
        public void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐈","🐈",
                "🐖","🐖",
                "🐠","🐠",
                "🐬","🐬",
                "🦜","🦜",
                "🦅","🦅",
                "🦘","🦘",
                "🦏","🦏"
            };

            foreach (TextBlock textBlock in grdMain.Children.OfType<TextBlock>())
            {
                index = nbAlea.Next(animalEmoji.Count);
                nextEmoji = animalEmoji[index];
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }
        }

        TextBlock derniereTBClique;
        bool trouvePaire = false;
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlockActif = sender as TextBlock;
            if (!trouvePaire)
            {
                textBlockActif.Visibility = Visibility.Hidden;
                derniereTBClique = textBlockActif;
                trouvePaire = true;
            }
            else if (textBlockActif.Text == derniereTBClique.Text)
            {
                textBlockActif.Visibility = Visibility.Hidden;
                trouvePaire = false;
            }
            else
            {
                derniereTBClique.Visibility = Visibility.Visible;
                trouvePaire = false;
            }
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            tempsEcoule++;
            txtTemps.Text = (tempsEcoule / 10f).ToString("0.0s");
            if (nbPairesTrouvees == 8)
            {
                timer.Stop();
                txtTemps.Text = txtTemps.Text + "Rejouer ?";
            }
        }
    }

}
