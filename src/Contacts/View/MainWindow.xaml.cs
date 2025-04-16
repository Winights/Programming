using System.Text;
using System.Windows;
using View.Controls;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var mainVm = new MainVM();
            DataContext = mainVm;
            ContactControl.DataContext = mainVm;
            Application.Current.Exit += (sender,e) => mainVm.SaveOnExit();
        }
    }
}
