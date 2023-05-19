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
            FrameClass.GeneralFrame.Navigate(new StartPage());
        }
        #region Обработчики события Button_Click

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
                TitleText = "";
            }
                
        }
        #endregion

        #region Обработчик MainFrame для BackButton
        private void MainFrame_ContentRendered(object sender, System.EventArgs e)
        {
            if (!MainFrame.CanGoBack)
                BackButton.Visibility = Visibility.Collapsed;
            else BackButton.Visibility = Visibility.Visible;
            TitlePageLabel.Content = TitleText;
        }
        #endregion
    }
}
