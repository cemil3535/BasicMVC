using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // Create a sample customer and orders
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };

            List<Order> orders = new List<Order>
            {

                new Order { Id = 1, ProductName = "Phone", ProductPrice = 1290, Quantity = 5 },
                new Order { Id = 2, ProductName = "Computer", ProductPrice = 15000, Quantity = 3 },
                new Order { Id = 3, ProductName = "Car", ProductPrice = 100000, Quantity = 1 }

                };

            // Create a CustomerOrderViewModel instance
            CustomerOrderViewModel viewModel = new CustomerOrderViewModel
            {

                Customer = customer,
                Orders = orders

            };

            // Pass the viewModel to the view
            return View(viewModel);
        }
    }
}
