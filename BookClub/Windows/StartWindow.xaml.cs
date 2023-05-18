using System.Windows;
using BookClub.Context;
using BookClub.Pages;


namespace BookClub
{
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
            FrameClass.GeneralFrame = MainFrame;
        }

        private void AuthoButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Находится в разработке!", 
                "Сообщение пользователю", 
                MessageBoxButton.OK, 
                MessageBoxImage.Information);
        }

        /// <summary>
        /// Для перехода к списку товаров как гость.
        /// </summary>
        private void GuestButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Добро пожаловать!",
                "Книжный клуб",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            MainStackPanel.Visibility = Visibility.Collapsed;
            FrameClass.GeneralFrame.Navigate(new ProductPage());
        }
    }
}
