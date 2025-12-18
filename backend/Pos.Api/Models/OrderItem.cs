namespace Pos.Api.Models
{
    public class OrderItem
    {

        public int OrderItemId { get; set; }    // thêm vào khi chuyen sql co dung
        public int ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty; // snapshot
        public decimal UnitPrice { get; set; }                  // snapshot
        public int Quantity { get; set; }
        public decimal LineTotal { get; set; }
    }
}
