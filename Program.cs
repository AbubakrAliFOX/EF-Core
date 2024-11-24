using EF_Core.Models;
using EF_Core.Data;

using AppDbContext context = new AppDbContext();

Product veggiePizza = new Product()
{
    Name = "Veggie Special Pizza",
    Price = 9.99M
};

Product meatPizza = new Product()
{
    Name = "Meat Special Pizza",
    Price = 10.6M
};

context.Products.Add(veggiePizza);
context.Add(meatPizza);