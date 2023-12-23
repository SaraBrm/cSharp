public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string OrderDate { get; set; }
    public int TotalPrice { get; set; }

    public Order(int id, int customerId, int totalPrice)
    {
        Id = id;
        CustomerId = customerId;
        OrderDate = DateTime.Now.ToShortDateString();
        TotalPrice = totalPrice;
    }
}
