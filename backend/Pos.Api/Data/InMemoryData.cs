using Pos.Api.Models;

namespace Pos.Api.Data
{
    public class InMemoryData
    {
        // Seed danh sách sản phẩm (POS dùng để hiển thị)
        public static readonly List<Product> Products = new()
    {
        new Product { ProductId = 1, Name = "Cà phê sữa", Price = 30000 },
        new Product { ProductId = 2, Name = "Trà đào", Price = 25000 },
        new Product { ProductId = 3, Name = "Bánh mì", Price = 20000 },
        new Product { ProductId = 4, Name = "Nước suối", Price = 10000 },
        new Product { ProductId = 5, Name = "Soda chanh", Price = 28000 },
    };

        // Danh sách đơn hàng (lát nữa Orders API sẽ dùng)
        public static readonly List<Order> Orders = new();
    }
}
