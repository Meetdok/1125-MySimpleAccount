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
    /// Логика взаимодействия для MusicWin.xaml
    /// </summary>
    public partial class MusicWin : Window, INotifyPropertyChanged
    {
        private Music selectedMusic;

        public Music SelectedMusic
        {
            get => selectedMusic;
            set
            {
                selectedMusic = value;
                Signal();
            }
        }

        public ObservableCollection<Music> Musics
        {
            get => Data.Musics;
        }
        public MusicWin()
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

        private void AddMusic(object sender, RoutedEventArgs e)
        {
            Musics.Add(new Music { Title = "Трек" });
        }

        private void DeleteMusic(object sender, RoutedEventArgs e)
        {

            if (SelectedMusic == null)
                return;
            if (MessageBox.Show("Действительно удалить выбраный трек?",
                "Предупреждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Musics.Remove(SelectedMusic);
            }
        }
    }
}
