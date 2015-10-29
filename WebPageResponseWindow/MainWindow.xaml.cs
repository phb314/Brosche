using System.Windows;

namespace WebPageResponseWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string Text
        {
            set
            {
                textBoxWebPageResponse.Text = value;
            }
        }
    }
}
