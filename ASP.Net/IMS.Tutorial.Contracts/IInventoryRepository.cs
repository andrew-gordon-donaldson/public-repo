namespace IMS.Tutorial.Contracts;

public interface IInventoryRepository
{
    Task AddInventoryItemAsync(InventoryItem inventoryItem);
    Task<InventoryItem> GetInventoryItemByIdAsync(int itemId);
    Task<IEnumerable<InventoryItem>> GetInventoryItemsByNameAsync(string name);
    Task UpdateAsync(InventoryItem inventoryItem);
}
