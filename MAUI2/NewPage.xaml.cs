using System;
using Microsoft.Maui.Controls;

namespace MAUI2
{
    public partial class NewPage : ContentPage
    {
        public NewPage()
        {
            InitializeComponent();
        }

        private async void AddItem_Clicked(object sender, EventArgs e)
        {
            string itemType = ItemTypePicker.SelectedItem.ToString();
            decimal price = decimal.Parse(PriceEntry.Text);
            string country = CountryEntry.Text;
            string name = NameEntry.Text;
            string description = DescriptionEntry.Text;
            DateTime expiryDate = ExpiryDateEntry.Date;
            int quantity = int.Parse(QuantityEntry.Text);
            string unitOfMeasure = UnitOfMeasureEntry.Text;
            int pageCount = int.Parse(PageCountEntry.Text);
            string publisher = PublisherEntry.Text;
            string authors = AuthorsEntry.Text;

            if (itemType.Equals("Product"))
            {
                Product newProduct = new Product
                {
                    Price = price,
                    CountryOfOrigin = country,
                    Name = name,
                    Description = description,
                    ExpiryDate = expiryDate,
                    Quantity = quantity,
                    UnitOfMeasure = unitOfMeasure
                };
                ((MainPage)App.Current.MainPage).Products.Add(newProduct);
            }
            else if (itemType.Equals("Book"))
            {
                Book newBook = new Book
                {
                    Price = price,
                    CountryOfOrigin = country,
                    Name = name,
                    Description = description,
                    PageCount = pageCount,
                    Publisher = publisher,
                    Authors = new List<string>(authors.Split(','))
                };
                ((MainPage)App.Current.MainPage).Books.Add(newBook);
            }

            await Navigation.PopAsync();
        }
    }
}
