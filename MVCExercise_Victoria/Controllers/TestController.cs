using Microsoft.AspNetCore.Mvc;
using MVCExercise_Victoria.Models;
using MVCExercise_Victoria.Services;
using MVCExercise_Victoria.ViewModels;

namespace MVCExercise_Victoria.Controllers
{
    public class TestController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        public TestController(ICustomerService customerService, IProductService productService) 
        {
            _customerService = customerService;
            _productService = productService;
        }
        public IActionResult ProductCustomer()
        {
            ProductCustomerViewModel viewModel = new ProductCustomerViewModel();
            viewModel.Products = _productService.GetProducts();
            viewModel.Customers = _customerService.GetCustomers();
            return View(viewModel);
        }

        public IActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            _customerService.CreateCustomer(customer);
            return RedirectToAction("ProductCustomer");
        }

        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _productService.CreateProduct(product);
            return RedirectToAction("ProductCustomer");
        }
    }

}

