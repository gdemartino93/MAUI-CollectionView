using MAUI_CollectionView.MVVM.ViewModels;

namespace MAUI_CollectionView.MVVM.Views;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();
	}
}