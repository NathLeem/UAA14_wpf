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

namespace CeUAA14Partie2_dec22_leemans
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] numero = new Button[10, 10];
        Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            Interface();
            SetUpGame();
            //TourJoueur();
        }

        public void Interface()
        {
            for (int i = 0; i < 10; i++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                grdBody.ColumnDefinitions.Add(colDef);
                RowDefinition rowDef = new RowDefinition();
                grdBody.RowDefinitions.Add(rowDef);
            }


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    numero[i, j] = new Button();

                    if (i % 2 == 0)
                    {
                        numero[i, j].Content = (10 * i) + j + 1;
                    }
                    else
                    {
                        numero[i, j].Content = (10 * i) + 10 - j;
                    }

                    if ((i + 1) % 2 == 0)
                    {
                        if ((j + 1) % 2 != 0)
                        {
                            numero[i, j].Background = Brushes.Aqua;
                        }
                        else
                        {
                            numero[i, j].Background = Brushes.Red;
                        }
                    }
                    else
                    {
                        if ((j + 1) % 2 == 0)
                        {
                            numero[i, j].Background = Brushes.Aqua;
                        }
                        else
                        {
                            numero[i, j].Background = Brushes.Red;
                        }
                    }

                    Grid.SetColumn(numero[i, j], j);
                    Grid.SetRow(numero[i, j], i);
                    grdBody.Children.Add(numero[i, j]);
                }
            }
        }
        int totalJoueur;
        int de;
        int reste = 1;
        int[] positionPionJoueur;
        string ancienneValeur;
        public void SetUpGame()
        {
            if (TDde.Text == "?")
            {
                TDde.Text = "Dé : " + rnd.Next(1,7);
            }
        }
        public void TourJoueur()
        {
            de = rnd.Next(1, 7);
            totalJoueur = totalJoueur + de;
            reste = totalJoueur - 10 * (positionPionJoueur[0] +1);
            if (reste < 0)
            {
                reste = reste + 10;
            }
            else
            {
                positionPionJoueur[0] = positionPionJoueur[0] + 1;
            }
            if (positionPionJoueur[0] % 2 != 0)
            {
                positionPionJoueur[1] = 9 - reste;
            }
            else
            {
                positionPionJoueur[1] = reste;
            }
            if (positionPionJoueur[0] <= 9)
            {

            }
        }
    }
}
