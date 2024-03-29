using CheckersGame.ViewModels;
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

namespace CheckersGame.Views
{
    /// <summary>
    /// Interaction logic for Meniu.xaml
    /// </summary>
    public partial class Meniu : Page
    {
        public Meniu()
        {
            InitializeComponent();
        }

        private void NewGameBtn_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).MainFrame.Navigate(new NewGameView(this.DataContext));
        }

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MeniuViewModel).LoadGameCommand();
            ((MainWindow)Application.Current.MainWindow).MainFrame.Navigate(new GameView(this.DataContext));
        }

        private void StatisticsBtn_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).MainFrame.Navigate(new StatisticsView(this.DataContext));
        }

        private void AboutBtn_Click_1(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).MainFrame.Navigate(new AboutView(this.DataContext));
        }
    }
}
