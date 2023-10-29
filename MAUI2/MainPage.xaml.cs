using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace MAUI2
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Good> Products { get; set; }
        public ObservableCollection<Good> Books { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Products = new ObservableCollection<Good>();
            Books = new ObservableCollection<Good>();

            itemsListViewProducts.ItemsSource = Products;
            itemsListViewBooks.ItemsSource = Books;
        }

        private void AddItem_Clicked(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(PriceEntry.Text);
            string country = CountryEntry.Text;
            string name = NameEntry.Text;
            DateTime packagingDate = DateTime.Now; // Update this to the actual date
            string description = DescriptionEntry.Text;

            if (ItemTypePicker.SelectedItem.Equals("Продукти"))
            {
                Product newProduct = new Product
                {
                    Price = price,
                    CountryOfOrigin = country,
                    Name = name,
                    PackagingDate = packagingDate,
                    Description = description,
                    ExpiryDate = ExpiryDateEntry.Date,
                    Quantity = int.Parse(QuantityEntry.Text),
                    UnitOfMeasure = UnitOfMeasureEntry.Text
                };
                Products.Add(newProduct);
            }
            else if (ItemTypePicker.SelectedItem.Equals("Книги"))
            {
                Book newBook = new Book
                {
                    Price = price,
                    CountryOfOrigin = country,
                    Name = name,
                    PackagingDate = packagingDate,
                    Description = description,
                    PageCount = int.Parse(PageCountEntry.Text),
                    Publisher = "Publisher", 
                    Authors = new List<string> { "Author" } 
                };
                Books.Add(newBook);
            }
        }

        private void ItemTypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = ItemTypePicker.SelectedItem.ToString();

            if (selectedItem == "Продукти")
            {
                AddItemButton.Text = "Додати новий продукт";
                PageCountLabel.IsVisible = false;
                PageCountEntry.IsVisible = false;
            }
            else if (selectedItem == "Книги")
            {
                AddItemButton.Text = "Додати нову книгу";
                PageCountLabel.IsVisible = true;
                PageCountEntry.IsVisible = true;
            }
        }
    }
}
