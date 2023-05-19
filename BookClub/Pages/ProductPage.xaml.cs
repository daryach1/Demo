using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using BookClub.Context;
using BookClub.Windows;


namespace BookClub.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        BookClubEntities Context;
        public ProductPage()
        {
            InitializeComponent();
            ViewOrderButton.IsEnabled = false;
            StartWindow.TitleText = Title.ToString();
            BaseWork();
        }
        #region Обработчики событий
        private void GenerOrderButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var CurrentProduct = (Products)ProductDataGrid.SelectedItem;
                ViewOrderWindow.ProductForOrder = CurrentProduct;
                ViewOrderButton.IsEnabled = true;
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка в работе приложения",
                    "Книжный клуб",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
        private void ViewOrderButton_Click(object sender, RoutedEventArgs e)
        {
            ViewOrderWindow ViewOrderWindow = new ViewOrderWindow();
            ViewOrderWindow.ShowDialog();
        }
        private void AddOrderMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Различные методы для работы

        /// <summary>
        /// Метод для присваивания значений из базы данных
        /// </summary>
        private void BaseWork()
        {
            Context = new BookClubEntities();
            ProductDataGrid.ItemsSource = Context.Products.ToList();
        }

        #endregion
    }
}
