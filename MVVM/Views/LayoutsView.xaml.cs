using MAUI_CollectionView.MVVM.ViewModels;

namespace MAUI_CollectionView.MVVM.Views;

public partial class LayoutsView : ContentPage
{
	public LayoutsView()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();

	}
}