using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MySimpleAccount
{
    /// <summary>
    /// Логика взаимодействия для GameWin.xaml
    /// </summary>
    public partial class GameWin : Window, INotifyPropertyChanged
    {
        private Game selectedGame;

        public Game SelectedGame
        {
            get => selectedGame;
            set
            {
                selectedGame = value;
                Signal();
            }
        }

        public ObservableCollection<Game> Games
        {
            get => Data.Games;
        }
        public GameWin()
        {
            InitializeComponent();
            DataContext = this;
        }

        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void AddGame(object sender, RoutedEventArgs e)
        {
            Games.Add(new Game { Name = "Игра" });
        }

        private void DeleteGame(object sender, RoutedEventArgs e)
        {

            if (SelectedGame == null)
                return;
            if (MessageBox.Show("Действительно удалить выбраную игру?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Games.Remove(SelectedGame);
            }
        }
    }
}
