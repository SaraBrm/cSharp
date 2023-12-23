// Multiple Join

using System.Diagnostics;

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

//var query = Orders.Join(
//            OrdersDetails,
//            order => order.Id,
//            orderDetail => orderDetail.OrderId,
//            (order, orderDetail) => new { order, orderDetail })
//            .Join(Products,
//            result1 => result1.orderDetail.ProductId,
//            product => product.Id,
//            (result1, product) => new { result1, product })
//            .Select(x => new
//            {
//                OrderId = x.result1.order.Id,
//                OrderDate = x.result1.order.OrderDate,
//                ProductName = x.product.Name,
//                Price = x.product.Price,
//                Quantity = x.result1.orderDetail.Quantity,
//                Amount = x.result1.orderDetail.Amount,
//            })
//            .OrderByDescending(x=>x.OrderId);

var query = from order in Orders
            join orderDetail in OrdersDetails
            on order.Id equals orderDetail.OrderId
            join product in Products
            on orderDetail.ProductId equals product.Id
            orderby order.Id
            select new
            {
                OrderId = order.Id,
                OrderDate = order.OrderDate,
                ProductName = product.Name,
                Price = product.Price,
                Quantity = orderDetail.Quantity,
                Amount = orderDetail.Amount
            };

Console.WriteLine("\n {0,-10}{1,-12}{2,-14}{3,-9}{4,-11}{5,-9}",
    "OrderId", "OrderDate", "ProductName", "Price", "Quantity", "Amount");

foreach (var item in query)
{
    Console.WriteLine("\n {0,-10}{1,-12}{2,-14}{3,-9}{4,-11}{5,-9}",
        item.OrderId, item.OrderDate, item.ProductName, item.Price, item.Quantity, item.Amount);
}

Console.ReadKey();




