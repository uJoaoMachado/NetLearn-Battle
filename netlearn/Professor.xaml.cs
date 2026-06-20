using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NetLearnBattle
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EsconderTudo()
        {
            GridPainel.Visibility = Visibility.Collapsed;
            GridSessao.Visibility = Visibility.Collapsed;
            GridStats.Visibility = Visibility.Collapsed;
            GridAcl.Visibility = Visibility.Collapsed;
        }

        private void BtnPainel_Click(object sender, RoutedEventArgs e)
        {
            EsconderTudo();
            GridPainel.Visibility = Visibility.Visible;
        }

        private void BtnSessao_Click(object sender, RoutedEventArgs e)
        {
            EsconderTudo();
            GridSessao.Visibility = Visibility.Visible;
        }

        private void BtnStats_Click(object sender, RoutedEventArgs e)
        {
            EsconderTudo();
            GridStats.Visibility = Visibility.Visible;
        }

        private void BtnAcl_Click(object sender, RoutedEventArgs e)
        {
            EsconderTudo();
            GridAcl.Visibility = Visibility.Visible;
        }
    }
}