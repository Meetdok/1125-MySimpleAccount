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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MySimpleAccount
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Account selectedAccount;

        public ObservableCollection<Account> Accounts
        {
            get => Data.Accounts;
        }

        public ObservableCollection<Game> Games
        {
            get => Data.Games;
        }

        public ObservableCollection<Music> Musics
        {
            get => Data.Musics;
        }


        public Account SelectedAccount
        {
            get => selectedAccount;
            set
            {
                selectedAccount = value;
                Signal();
            }
        }


        void Signal([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this,
                      new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;









        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void AddAccount(object sender, RoutedEventArgs e)
        {
            Accounts.Add(new Account
            {
                NickName = "Новый аккаунт",
                Data = DateTime.Today
            });




        }

        private void DeleteAccount(object sender, RoutedEventArgs e)
        {

            if (selectedAccount == null)
                return;
            if (MessageBox.Show("Действительно удалить выбранный аккаунт?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Accounts.Remove(selectedAccount);
                selectedAccount = null;
            }

        }

        private void OpenGames(object sender, RoutedEventArgs e)
        {
            GameWin win = new GameWin();
            win.ShowDialog();

        }

        private void OpenMusics(object sender, RoutedEventArgs e)
        {
            MusicWin win = new MusicWin();
            win.ShowDialog();
        }

      
    }
}
