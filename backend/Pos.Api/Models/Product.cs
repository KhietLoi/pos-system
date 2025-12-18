namespace Pos.Api.Models
{
    public class Product
    {

        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        //Them OrderItem khi ko dung in,emory

    }
}
