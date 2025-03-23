using MAUI_CollectionView.MVVM.Models;

namespace MAUI_CollectionView.Selectors
{
    public class ProductDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Product product = item as Product;
            if (!product.HasOffer)
            {
                Application.Current.Resources.TryGetValue("ProductStyle", out var productStyle);
                return productStyle as DataTemplate;
            }
            return new DataTemplate();
        }
    }
}
