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

namespace CreaDynamique
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Interface();
        }

        public void Interface()
        {
            ColumnDefinition col1 = new ColumnDefinition();
            ColumnDefinition col2 = new ColumnDefinition();
            ColumnDefinition col3 = new ColumnDefinition();
            grdMain.ColumnDefinitions.Add(col1);
            grdMain.ColumnDefinitions.Add(col2);
            grdMain.ColumnDefinitions.Add(col3);

            RowDefinition row1 = new RowDefinition();
            RowDefinition row2 = new RowDefinition();
            RowDefinition row3 = new RowDefinition();
            grdMain.RowDefinitions.Add(row1);
            grdMain.RowDefinitions.Add(row2);
            grdMain.RowDefinitions.Add(row3);

            TextBlock txtBlockDyna = new TextBlock();
            Button btn1 = new Button();
            Button btn2 = new Button();
            Button btn3 = new Button();
            TextBlock txtBlockInfo = new TextBlock();
            TextBox txtInfo = new TextBox();
            StackPanel stackInfo = new StackPanel();
            ComboBox comboItem = new ComboBox();

            Grid.SetRow(txtBlockDyna, 0);
            Grid.SetColumn(txtBlockDyna, 0);
            Grid.SetColumnSpan(txtBlockDyna, 3);
            Grid.SetColumn(btn1, 0);
            Grid.SetRow(btn1, 1);
            Grid.SetColumn(btn2, 1);
            Grid.SetRow(btn2, 1);
            Grid.SetColumn(btn3, 2);
            Grid.SetRow(btn3, 1);
            Grid.SetColumnSpan(stackInfo, 2);
            Grid.SetRow(stackInfo, 2);
            Grid.SetColumn(comboItem, 2);
            Grid.SetRow(comboItem, 2);


            stackInfo.Children.Add(txtBlockInfo);
            stackInfo.Children.Add(txtInfo);

            grdMain.Children.Add(txtBlockDyna);

            grdMain.Children.Add(btn1);
            grdMain.Children.Add(btn2);
            grdMain.Children.Add(btn3);

            grdMain.Children.Add(stackInfo);

            grdMain.Children.Add(comboItem);

            txtBlockDyna.Text = "Textblock créé dynamiquement";
            txtBlockDyna.Background = Brushes.Yellow;
            txtBlockDyna.Foreground = Brushes.Red;
            btn1.Content = "BOUTON 1";
            btn2.Content = "BOUTON 2";
            btn3.Content = "BOUTON 3";
            txtBlockInfo.Text = "infos :";
            txtBlockInfo.FontWeight = FontWeights.Bold;
            txtBlockInfo.Background = Brushes.Yellow;
            txtInfo.Text = "J'attends vos infos";
            comboItem.Items.Add("Combobo");
            comboItem.Items.Add("Itemmmsssss");



        }
    }
}
