using BookClub.Context;
using System.Windows;


namespace BookClub.Windows
{
    /// <summary>
    /// Логика взаимодействия для ViewOrderWindow.xaml
    /// </summary>
    public partial class ViewOrderWindow : Window
    {
        public static Products ProductForOrder;
        public ViewOrderWindow()
        {
            InitializeComponent();
        }
    }
}
