using MAUI_CollectionView.MVVM.ViewModels;
using System.Diagnostics;

namespace MAUI_CollectionView.MVVM.Views;

public partial class ProductsView : ContentPage
{
	public ProductsView()
	{
		InitializeComponent();
		BindingContext = new ProductsViewModel();
	}

    private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
		Debug.WriteLine($"primo elemento: {e.FirstVisibleItemIndex}");
        Debug.WriteLine($"secondo elemento: {e.CenterItemIndex}");
        Debug.WriteLine($"terzo elemento: {e.LastVisibleItemIndex}");
        Debug.WriteLine($"delta orzzontale: {e.HorizontalDelta}");
        Debug.WriteLine($"delta verticale: {e.VerticalDelta}");
        Debug.WriteLine($"offset vertical: {e.VerticalOffset}");
        Debug.WriteLine($"offset orizzontale: {e.VerticalOffset}");
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var vm = BindingContext as ProductsViewModel;
        if ( vm != null )
        {
            var product = vm.Products
                .SelectMany(p => p)
                .FirstOrDefault(x => x.Id == 10);
            collectionview.ScrollTo(product, null, ScrollToPosition.Start, true);
        }
    }
}