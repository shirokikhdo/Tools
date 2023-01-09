using DemoWpfMvvm.ViewModels;
using System.Windows;

namespace DemoWpfMvvm.Views
{
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}