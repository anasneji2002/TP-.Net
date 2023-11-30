using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ViewModelController : Controller
    {
        public IActionResult Index()
        {   Movie movie = new Movie() { Name = "movie 1" };
            List<Customer> customers = new List<Customer>()
            { new Customer{Name="Anas"} , new Customer{Name="Neji"} , new Customer{Name="Mohamed"}};
            ViewModel viewModel = new ViewModel() { Movie=movie , Customers=customers};
            return View(viewModel);
        }

        public IActionResult Client(int id)
        {
            Movie movie = new Movie() { Name = "movie 1" };
            List<Customer> customers = new List<Customer>()
            { new Customer{Name="Anas"} , new Customer{Name="Neji"} , new Customer{Name="Mohamed"}};
            ViewModel viewModel = new ViewModel() { Movie = movie, Customers = customers };
            bool found = false;
            Customer customer1 = null;
            foreach(var customer in viewModel.Customers )
            {
                if(customer.Id == id)
                {
                    found = true;
                    customer1 = customer;
                    break;

                }
            }
            if(!found)
            {
                return Content("Error 404 : not found");
            }
            return View(customer1);
        }
    }
}
