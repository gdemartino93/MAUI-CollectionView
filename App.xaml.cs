using MAUI_CollectionView.MVVM.Views;

namespace MAUI_CollectionView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LayoutsView();
        }
    }
}
