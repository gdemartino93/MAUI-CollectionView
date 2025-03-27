using MAUI_CollectionView.MVVM.ViewModels;

namespace MAUI_CollectionView.MVVM.Views;

public partial class ProductsView : ContentPage
{
	public ProductsView()
	{
		InitializeComponent();
		BindingContext = new ProductsViewModel();
	}
}