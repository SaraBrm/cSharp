public class OrderDetails
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public int Amount { get; set; }

    public OrderDetails(int id, int orderId, int productId, int quantity, int amount)
    {
        Id = id;
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
        Amount = amount;
    }
}