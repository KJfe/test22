using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using test22.View;
using test22.ViewModel;

namespace test22
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var mw = new MainWindowView
            {
                DataContext = new MainViewModel()
            };

            mw.Show();
        }
    }
}
