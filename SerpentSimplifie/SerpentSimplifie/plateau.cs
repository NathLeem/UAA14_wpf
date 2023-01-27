using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;

namespace SerpentSimplifie
{
    class plateau
    {
        public void Interface()
        {
            MainWindow plateau = (SerpentSimplifie.MainWindow)App.Current.MainWindow;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    plateau.btnCases[i, j] = new Button();
                    plateau.btnCases[i, j].Width = 60;
                    plateau.btnCases[i, j].Height = 60;
                    plateau.btnCases[i, j].Content = calculNum(i,j);
                }
            }
        }
        public void calculNum()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                }
            }
        }
    }
}
