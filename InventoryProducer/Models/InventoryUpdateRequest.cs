namespace InventoryProducer.Models
{
    public class InventoryUpdateRequest
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}