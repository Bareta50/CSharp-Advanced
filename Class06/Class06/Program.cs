using Class06;
using Class06.Helper;

Product product = new Product
{
    Id = 1,
    Name = "Laptop",
    Price = 1000
};
Product product2 = new Product
{
    Id = 2,
    Name = "Phone",
    Price = 500
};
Product product3 = new Product
{
    Id = 3,
    Name = "Tablet",
    Price = 300
};

product3.GetTotalPrice(3);
Console.WriteLine($"Total Price of {product3.Name} is {product3.Price}");