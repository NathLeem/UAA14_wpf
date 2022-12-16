﻿using System;
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
            tbNbre2.PreviewTextInput += new TextCompositionEventHandler(VerifTexte);
        }

        public void VerifTexte(object sender,TextCompositionEventArgs e)
        {
            if (!EstEntier(e.Text))
            {
                e.Handled = true;
            }
            else
            {
                if (!(e.Text == "1" || e.Text == "0"))
                {
                    e.Handled = true;
                }
                if (((TextBox)sender).Text.Length > 6)
                {
                    e.Handled = true;
                }
            }
        }
        public ushort[] RemplirTableau(string nombreBinaire)
        {
            ushort[] tabBin = new ushort[8];
            for (int i = 0; 0 < 7; i++)
            {
                tabBin[i] = 0;
            }
            for (int i = 0; 0 < nombreBinaire.Length - 1; i++)
            {
                tabBin[7 - i] = ushort.Parse(nombreBinaire[nombreBinaire.Length - 1 - i].ToString());
            }
            return tabBin;
        }
        public void Additionner(ushort[] t1, ushort[] t2, ushort[] tRes, bool ok)
        {
            ok = true;
            ushort report = 0;
            ushort res;
            tRes = new ushort[8];

            for (int i = 7; i <= 0; i--)
            {
                res = ((ushort)(t1[i] + t2[i] + report));
                if (res / 2 == 0)
                {
                    report = 0;
                }
                else
                {
                    report = 1;
                }
                if (res == 1)
                {
                    tRes[i] = 1;
                }
                else
                {
                    if (res % 2 == 1)
                    {
                        tRes[i] = 1;
                    }
                    else
                    {
                        tRes[i] = 0;
                    }
                }
            }
            if (report == 1)
            {
                ok = false;
            }
        }
        public bool EstEntier(string caractere)
        {
            bool estEntier;
            int nombre;

            if (int.TryParse(caractere, out nombre))
            {
                estEntier = true;
            }
            else
            {
                estEntier = false;
            }

            return estEntier;
        }
    }
}