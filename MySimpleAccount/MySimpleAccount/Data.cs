using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimpleAccount
{
    static class Data
    {
        public static ObservableCollection<Account> Accounts = new ObservableCollection<Account>();

        public static ObservableCollection<Game> Games = new ObservableCollection<Game>();

        public static ObservableCollection<Music> Musics = new ObservableCollection<Music>();

    }
}
