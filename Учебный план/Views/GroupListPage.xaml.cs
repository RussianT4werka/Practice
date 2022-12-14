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
using Учебный_план.ViewModels;

namespace Учебный_план.Views
{
    /// <summary>
    /// Логика взаимодействия для GroupListPage.xaml
    /// </summary>
    public partial class GroupListPage : Page
    {
        public GroupListPage(MainWindowVM mainViewModel)
        {
            InitializeComponent();
            DataContext = new GroupListPageVM(mainViewModel);
        }
    }
}
