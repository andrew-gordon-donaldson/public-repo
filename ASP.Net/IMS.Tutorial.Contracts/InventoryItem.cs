using System.ComponentModel.DataAnnotations;

namespace IMS.Tutorial.Contracts;

public class InventoryItem
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    [Range(0, int.MaxValue,ErrorMessage = "Quantity is out of range.")]
    public int Quantity { get; set; } = 0;
    [Range(0,double.MaxValue, ErrorMessage = "Price is out of range.")]
    public double PurchasePrice { get; set; } = 0d;

    public InventoryItem() { }

    public InventoryItem(InventoryItem item)
    {
        Id = item.Id;
        Name = item.Name;
        Description = item.Description;
        Quantity = item.Quantity;
        PurchasePrice = item.PurchasePrice;
    }
}