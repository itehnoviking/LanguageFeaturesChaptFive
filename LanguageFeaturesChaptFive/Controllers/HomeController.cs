using LanguageFeaturesChaptFive.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LanguageFeaturesChaptFive.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //bool FilterByPrice(Product p)
        //{
        //    return (p?.Price ?? 0) >= 20;
        //}

        public async Task<IActionResult> Index()
        {
            List<string> output = new List<string>();
            await foreach (long? len in MyAsyncMethod.GetPageLength(output, "meshok.net", "ru.ucoin.net", "ay.by"))
            {
                output.Add($"Page length: { len}");
            }

            return View(output);

            #region test
            //long? length = await MyAsyncMethod.GetPageLength();
            //return View(new string[]
            //{
            //    $"Length: {length}"
            //});

            //IProductSelection cart = new ShoppingCart
            //    (
            //      new Product { Name = "1 копейка серебром 1844 г. Е.М.", Price = 1100M },
            //      new Product { Name = "Полушка 1736 г.", Price = 180M },
            //      new Product { Name = "Денга 1750 г.", Price = 150M },
            //      new Product { Name = "Полушка 1735 г.", Price = 170M }
            //    );



            //return View(cart.Names);




            //return View(Product.GetProducts().Select(p => p?.Name));

            //Product[] productArray =
            //{
            //    new Product
            //    {
            //        Name = "1 копейка серебром 1844 г. Е.М.",
            //        Price = 1100M
            //    },

            //    new Product
            //    {
            //        Name = "Полушка 1736 г.",
            //        Price = 180M
            //    },

            //    new Product
            //    {
            //        Name = "Денга 1750 г.",
            //        Price = 150M
            //    },

            //    new Product
            //    {
            //        Name = "Полушка 1735 г.",
            //        Price = 170M
            //    }
            //};

            //Func<Product, bool> nameFilter = delegate (Product prod)
            //{
            //    return prod?.Name?[0] == 'П';
            //};

            //decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 200).TotalPrices();
            //decimal nameFilterTotal = productArray.Filter(p => p?.Name?[0] == 'П').TotalPrices();

            //return View("Index", new string[]
            //{
            //    $"Price Total: {priceFilterTotal:C2}",
            //    $"Name Total: {nameFilterTotal:C2}"
            //});

            #endregion
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}