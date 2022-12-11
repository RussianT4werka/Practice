using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Учебный_план.Tools;
using Учебный_план.Views;

namespace Учебный_план.ViewModels
{
    internal class MainWindowVM:BaseVM
    {
        private Page currentPage;
        private Window parent;

        public Command BorderMouseDown { get; set; }
        public Command MinimizeWindow { get; set; }
        public Command CloseApp { get; set;}
        public Command WindowAppState { get; set; }

        public MainWindowVM()
        {
            CurrentPage = new GroupListPage(this);

            BorderMouseDown = new Command(() =>
            {
                Border_MouseDown();
            });

            MinimizeWindow = new Command(() =>
            {
                Button_Minimize_Click();
            });

            CloseApp = new Command(() =>
            {
                CloseButton_Click();
            });

            WindowAppState = new Command(() =>
            {
                WindowStateButton_Click();
            });
        }
        public void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                var window = parent;
                window.DragMove();
            }
        }

        //Свернуть приложение
        public void Button_Minimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        public void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void WindowStateButton_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
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
