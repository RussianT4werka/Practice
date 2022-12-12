using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Учебный_план.Tools;
using Учебный_план.Views;

namespace Учебный_план.ViewModels
{
    public class MainWindowVM:BaseVM
    {
        private Page currentPage;

        public MainWindowVM()
        {
            CurrentPage = new GroupListPage(this);
        }
        public Page CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                SignalChanged();
            }
        }
    }
}
