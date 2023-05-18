using System.Security.Cryptography.X509Certificates;
using System.Windows;
using BookClub.Context;
using BookClub.Pages;


namespace BookClub
{
    public partial class StartWindow : Window
    {
        public static string TitleText = "";
        public StartWindow()
        {
            InitializeComponent();
            FrameClass.GeneralFrame = MainFrame;
        }
        #region Обработчики события Button_Click
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
            try
            {
                MessageBox.Show("Добро пожаловать!",
                    "Книжный клуб",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                MainStackPanel.Visibility = Visibility.Collapsed;
                FrameClass.GeneralFrame.Navigate(new ProductPage());
                TitlePageLabel.Content = TitleText;
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка в работе приложения",
                    "Книжный клуб",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
           
        }
        #endregion
    }
}
