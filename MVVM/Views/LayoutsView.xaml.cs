using MAUI_CollectionView.MVVM.ViewModels;

namespace MAUI_CollectionView.MVVM.Views;

public partial class LayoutsView : ContentPage
{
	public LayoutsView()
	{
		InitializeComponent();
		BindingContext = new DataViewModel();

	}

    private void Button_Search_Clicked(object sender, EventArgs e)
    {
		if(collectionView.EmptyView == Resources["NoResultView"])
		{
            collectionView.EmptyView = Resources["NetworkErrorView"];
			return;
        }
		collectionView.EmptyView = Resources["NoResultView"];

    }
}