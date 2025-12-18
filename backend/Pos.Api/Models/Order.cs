namespace Pos.Api.Models
{
    public class Order
    {
        public Guid  OrderId { get; set; }
        public string OrderCode { get; set; } = string.Empty;
        public decimal TotalAmount { get; set; }
        public DateTime PaidAt { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}
