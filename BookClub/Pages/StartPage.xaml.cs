using BookClub.Context;
using System.Windows;
using System.Windows.Controls;


namespace BookClub.Pages
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void GuestButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show("Добро пожаловать!",
                    "Книжный клуб",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                FrameClass.GeneralFrame.Navigate(new ProductPage());
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка в работе приложения",
                    "Книжный клуб",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void AuthoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Находится в разработке!",
                    "Книжный клуб",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
        }
    }
}
