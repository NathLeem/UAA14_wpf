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

namespace MatchingGameDynamique
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBlock[,] txtBlock = new TextBlock[4,4];
        
        public MainWindow()
        {
            InitializeComponent();
            InitialiseInterface();
        }

        public void InitialiseInterface()
        {
            for (int i = 0; i < 4; i++)
            {
                ColumnDefinition colDef = new ColumnDefinition();
                grdMain.ColumnDefinitions.Add(colDef);
                RowDefinition rowDef = new RowDefinition();
                grdMain.RowDefinitions.Add(rowDef);
            }


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    txtBlock[i, j] = new TextBlock();
                    txtBlock[i, j].Text = "?";
                    Grid.SetColumn(txtBlock[i, j], j);
                    Grid.SetRow(txtBlock[i, j], i);
                    grdMain.Children.Add(txtBlock[i,j]);
                }
            }
        }
    }
}
