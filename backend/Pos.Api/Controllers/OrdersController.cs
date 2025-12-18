using Microsoft.AspNetCore.Mvc;
using Pos.Api.Data;
using Pos.Api.Dtos;
using Pos.Api.Models;
namespace Pos.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController:ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        => Ok(InMemoryData.Orders.OrderByDescending(o => o.PaidAt));

        [HttpPost]
        public IActionResult Create([FromBody] CreateOrderRequest request)
        {
            //Truong hop don hang trong
            if (request?.Items == null || request.Items.Count == 0)
            {
               return BadRequest("Cart is empty");
            }

            //Tao order moi:
            var order = new Order
            {
                OrderId = Guid.NewGuid(),
                OrderCode = $"OD{DateTime.Now:yyyyMMddHHmmss}",
                PaidAt = DateTime.Now
            };


            decimal total = 0;
            foreach (var item in request.Items)
            {
                if (item.Quantity <=0)
                {
                    return BadRequest("Quantity must be than 0");
                }

                var product = InMemoryData.Products.FirstOrDefault(p => p.ProductId == item.ProductId);

                if (product == null)
                {
                    return BadRequest($"ProductId {item.ProductId} not found");

                }
                var lineTotal = product.Price * item.Quantity;

                //SNAPSHOT: luu ten va gia tai thoi diem hien tai:

                order.Items.Add(new OrderItem
                {
                    OrderItemId = order.Items.Count + 1,
                    ProductId = product.ProductId,
                    ProductName = product.Name,
                    UnitPrice = product.Price,
                    Quantity = item.Quantity,
                    LineTotal = lineTotal
                });

                //tong tien don hang
                total += lineTotal;

            }

            order.TotalAmount = total;
            InMemoryData.Orders.Add(order);
            return Ok(new {message = "Payment Success", order});
        }
    }
}
