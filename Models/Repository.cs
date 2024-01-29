namespace FormsApp_SatisProjesi.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();

        private static readonly List<Category> _categories = new(); 

        static Repository()
        {
            _categories.Add(new Category { CategoryId = 1, Name = "Telefon" });
            _categories.Add(new Category { CategoryId = 2, Name = "Bilgisayar"});

            List<Product> products = new List<Product>();

            // Bilgisayar kategorisi için ürün ekleme
            _products.Add(new Product { ProductId = 1, Name = "Laptop XYZ", Price = 3000, IsActive = true, Image = "1.jpg", CategoryId = 2 });

            // Telefon kategorisi için ürün ekleme
            _products.Add(new Product { ProductId = 2, Name = "Samsung Galaxy S22", Price = 2500, IsActive = true, Image = "phone_image.jpg", CategoryId = 1 });

            // Başka bir bilgisayar ürünü ekleme
            _products.Add(new Product { ProductId = 3, Name = "Desktop ABC", Price = 5000, IsActive = true, Image = "desktop_image.jpg", CategoryId = 2 });

            // Başka bir telefon ürünü ekleme
            _products.Add(new Product { ProductId = 4, Name = "iPhone 15", Price = 4000, IsActive = true, Image = "iphone_image.jpg", CategoryId = 1 });

            // Başka bir bilgisayar ürünü ekleme
            _products.Add(new Product { ProductId = 5, Name = "Ultrabook 123", Price = 3500, IsActive = true, Image = "ultrabook_image.jpg", CategoryId = 2 });

            // Başka bir telefon ürünü ekleme
            _products.Add(new Product { ProductId = 6, Name = "Google Pixel 6", Price = 2800, IsActive = true, Image = "pixel_image.jpg", CategoryId = 1 });

            // Başka bir bilgisayar ürünü ekleme
            _products.Add(new Product { ProductId = 7, Name = "Gaming PC XYZ", Price = 7000, IsActive = true, Image = "gaming_pc_image.jpg", CategoryId = 2 });

            // Başka bir telefon ürünü ekleme
            _products.Add(new Product { ProductId = 8, Name = "OnePlus 9T", Price = 3200, IsActive = true, Image = "oneplus_image.jpg", CategoryId = 1 });


        }


        public static List<Product> _Products
        {
            get
            {
                return _products;
            }
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }


    }
}
