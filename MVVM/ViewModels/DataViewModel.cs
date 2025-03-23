using MAUI_CollectionView.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_CollectionView.MVVM.ViewModels
{
    public class DataViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
        public DataViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Name = "PlayStation 5",
                    Price = 499.99m,
                    Image = "ps5.jpg",
                    Stock = 20,
                    HasOffer = false,
                    OfferPrice = 0
                },
                new Product
                {
                    Name = "Xbox Series X",
                    Price = 479.99m,
                    Image = "xbox.jpg",
                    Stock = 15,
                    HasOffer = true,
                    OfferPrice = 429.99m
                },
                new Product
                {
                    Name = "Nintendo Switch OLED",
                    Price = 349.99m,
                    Image = "switch.jpg",
                    Stock = 10,
                    HasOffer = false,
                    OfferPrice = 0
                },
                new Product
                {
                    Name = "Steam Deck",
                    Price = 399.99m,
                    Image = "steamdeck.jpg",
                    Stock = 5,
                    HasOffer = true,
                    OfferPrice = 359.99m
                },
                new Product
                {
                    Name = "Apple AirPods Pro",
                    Price = 249.99m,
                    Image = "airpods.jpg",
                    Stock = 30,
                    HasOffer = true,
                    OfferPrice = 199.99m
                },
                new Product
                {
                    Name = "Samsung Galaxy Tab S9",
                    Price = 699.99m,
                    Image = "galaxytab.jpg",
                    Stock = 12,
                    HasOffer = false,
                    OfferPrice = 0
                },
                new Product
                {
                    Name = "PlayStation 5",
                    Price = 499.99m,
                    Image = "ps5.jpg",
                    Stock = 20,
                    HasOffer = false,
                    OfferPrice = 0
                },
                new Product
                {
                    Name = "Xbox Series X",
                    Price = 479.99m,
                    Image = "xbox.jpg",
                    Stock = 15,
                    HasOffer = true,
                    OfferPrice = 429.99m
                },
                new Product
                {
                    Name = "Nintendo Switch OLED",
                    Price = 349.99m,
                    Image = "switch.jpg",
                    Stock = 10,
                    HasOffer = false,
                    OfferPrice = 0
                },
                new Product
                {
                    Name = "Steam Deck",
                    Price = 399.99m,
                    Image = "steamdeck.jpg",
                    Stock = 5,
                    HasOffer = true,
                    OfferPrice = 359.99m
                },
                new Product
                {
                    Name = "Apple AirPods Pro",
                    Price = 249.99m,
                    Image = "airpods.jpg",
                    Stock = 30,
                    HasOffer = true,
                    OfferPrice = 199.99m
                },
                new Product
                {
                    Name = "Samsung Galaxy Tab S9",
                    Price = 699.99m,
                    Image = "galaxytab.jpg",
                    Stock = 12,
                    HasOffer = false,
                    OfferPrice = 0
                },new Product
                {
                    Name = "PlayStation 5",
                    Price = 499.99m,
                    Image = "ps5.jpg",
                    Stock = 20,
                    HasOffer = false,
                    OfferPrice = 0
                },
                new Product
                {
                    Name = "Xbox Series X",
                    Price = 479.99m,
                    Image = "xbox.jpg",
                    Stock = 15,
                    HasOffer = true,
                    OfferPrice = 429.99m
                },
                new Product
                {
                    Name = "Nintendo Switch OLED",
                    Price = 349.99m,
                    Image = "switch.jpg",
                    Stock = 10,
                    HasOffer = false,
                    OfferPrice = 0
                },
                new Product
                {
                    Name = "Steam Deck",
                    Price = 399.99m,
                    Image = "steamdeck.jpg",
                    Stock = 5,
                    HasOffer = true,
                    OfferPrice = 359.99m
                },
                new Product
                {
                    Name = "Apple AirPods Pro",
                    Price = 249.99m,
                    Image = "airpods.jpg",
                    Stock = 30,
                    HasOffer = true,
                    OfferPrice = 199.99m
                },
                new Product
                {
                    Name = "Samsung Galaxy Tab S9",
                    Price = 699.99m,
                    Image = "galaxytab.jpg",
                    Stock = 12,
                    HasOffer = false,
                    OfferPrice = 0
                },new Product
                {
                    Name = "PlayStation 5",
                    Price = 499.99m,
                    Image = "ps5.jpg",
                    Stock = 20,
                    HasOffer = false,
                    OfferPrice = 0
                },
                new Product
                {
                    Name = "Xbox Series X",
                    Price = 479.99m,
                    Image = "xbox.jpg",
                    Stock = 15,
                    HasOffer = true,
                    OfferPrice = 429.99m
                },
                new Product
                {
                    Name = "Nintendo Switch OLED",
                    Price = 349.99m,
                    Image = "switch.jpg",
                    Stock = 10,
                    HasOffer = false,
                    OfferPrice = 0
                },
                new Product
                {
                    Name = "Steam Deck",
                    Price = 399.99m,
                    Image = "steamdeck.jpg",
                    Stock = 5,
                    HasOffer = true,
                    OfferPrice = 359.99m
                },
                new Product
                {
                    Name = "Apple AirPods Pro",
                    Price = 249.99m,
                    Image = "airpods.jpg",
                    Stock = 30,
                    HasOffer = true,
                    OfferPrice = 199.99m
                },
                new Product
                {
                    Name = "Samsung Galaxy Tab S9",
                    Price = 699.99m,
                    Image = "galaxytab.jpg",
                    Stock = 12,
                    HasOffer = false,
                    OfferPrice = 0
                }
            };

        }
    }
}
