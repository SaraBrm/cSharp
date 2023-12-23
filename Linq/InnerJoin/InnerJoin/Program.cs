// Inner Join

List<Customer> Customers = new List<Customer>()
{
    new Customer(1, "sara", "bayrami", "09371212121"),
    new Customer(2, "sasan", "roshan", "09116545758"),
    new Customer(3, "bahar", "sabet", "09383498521"),
    new Customer(4, "ali", "azar", "09117859412"),
    new Customer(5, "Nasrin", "rad", "09023265987"),
};

List<Product> Products = new List<Product>()
{
    new Product(100, "Notebook" , "Eiffel" , 45000),
    new Product(101, "Marker" , "Kaikai" , 45000),
    new Product(102, "Pen" , "Nano" , 7000),
    new Product(103, "Study Lights" , "XY" , 48000),
    new Product(104, "Pen" , "Kian" , 6000),
    new Product(105, "Eraser" , "TC" , 24000),
};

List<Order> Orders = new List<Order>()
{
    new Order(200 , 1 , 138000),
    new Order(201 , 2 , 147000),
    new Order(202 , 3, 162000),
    new Order(203 , 4, 53000),
};

List<OrderDetails> OrdersDetails = new List<OrderDetails>()
{
    new OrderDetails(300, 200, 100 , 2, 90000),
    new OrderDetails(301, 200, 103 , 1, 48000),
    new OrderDetails(302, 201, 101 , 3, 135000),
    new OrderDetails(303, 201, 104 , 2, 12000),
    new OrderDetails(304, 202, 105 , 3, 72000),
    new OrderDetails(305, 202, 100 , 2, 90000),
    new OrderDetails(306, 203, 102 , 5, 35000),
    new OrderDetails(307, 203, 104 , 3, 18000),
};

//var result = Customers.Join(                                            // Outer Data Sources
//            Orders,                                                     // Inner Data Sources
//            customer => customer.Id,                                    // Outer Key
//            order => order.CustomerId,                                  // Inner Key
//            (customer, order) => new                                    // Projecting
//            {
//                OrderId = order.Id,
//                FullName = customer.Name + " " + customer.Family,
//                Mobile = customer.Mobile,
//                TotalPrice = order.TotalPrice,
//                OrderDate = order.OrderDate
//            });


var result = Customers.Join(
            Orders,
            customer => customer.Id,
            order => order.CustomerId,
            (customer, order) => new { customer, order })
            .OrderBy(x => x.order.TotalPrice)
            .Select(x => new
            {
                OrderId = x.order.Id,
                FullName = x.customer.Name + " " + x.customer.Family,
                Mobile = x.customer.Mobile,
                TotalPrice = x.order.TotalPrice,
                OrderDate = x.order.OrderDate
            });


//var result = from customer in Customers
//             join order in Orders
//             on customer.Id equals order.CustomerId
//             orderby order.TotalPrice descending
//             select new
//             {
//                 OrderId = order.Id,
//                 FullName = customer.Name + " " + customer.Family,
//                 Mobile = customer.Mobile,
//                 TotalPrice = order.TotalPrice,
//                 OrderDate = order.OrderDate
//             };

foreach (var item in result)
    Console.WriteLine("\n" + item);

Console.ReadKey();




