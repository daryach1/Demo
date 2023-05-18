using System.Windows.Controls;


namespace BookClub.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
            StartWindow.TitleText = Title.ToString();
        }

        private void GenerOrderButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
