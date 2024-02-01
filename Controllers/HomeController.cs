using FormsApp_SatisProjesi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace FormsApp_SatisProjesi.Controllers
{
    public class HomeController : Controller
    {
      
    

        public IActionResult Index(string searchString ,string category)
        {
            var products = Repository._Products;
            if (!String.IsNullOrEmpty(searchString))
            {
                ViewBag.SearchString = searchString;
                products = products.Where(p =>p.Name.ToLower().Contains(searchString)).ToList();
            }

            if (!String.IsNullOrEmpty(category))
            {
                products = products.Where(p=>p.CategoryId == int.Parse(category)).ToList();
            }



            //ViewBag Kullanarak
            //ViewBag.price = new SelectList(Repository._Products, "Name","Price");
            ViewBag.Categories = new SelectList(Repository.Categories,"CategoryId", "Name",category);
            //en sondaki category secim yaptiktan sonra sutunun icinde yaziyor 
            //yani sutun ici bos kalmiyor secim orda kaliyor

            var model = new ProductViewModel
            {
                Products = products,
                Categories = Repository.Categories,
                SelectedCategory = category
            };
            return View(model);

            
        }

        [HttpGet]
        public IActionResult Create() 
        {
            ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
            return View();
        
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product model,IFormFile imageFile)
        {
            var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
            var extension = Path.GetExtension(imageFile.FileName);// Gelen resmin uzaatnisini alma.
            var randomFileName = string.Format($"{Guid.NewGuid().ToString()}{extension}");
                 //Guid.NewGuid() dosyaya benzersiz bir isim atar.
                //Dosyayi aldik ve sonuna uzanti kismini ekledik.

          

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", randomFileName);
            //Dosyanin kayit edilecegi yol.
            if (ModelState.IsValid)
            {
                //path dosya yolu
                //FileMode.Create ifadesi, dosyanın oluşturulacağını ve varsa üzerine yazılacağını belirtir.
                //FileStream sınıfının bir örneği oluşturuluyor. Bu, dosyaya yazmak için bir akış sağlar.
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }
                model.Image = randomFileName;
                model.ProductId = Repository._Products.Count() + 1;
                Repository.CreateProduct(model);
                return RedirectToAction("Index");
            }

            ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
            return View(model);

        }

    
    }
}