using Bogus;
using IMS.Tutorial.Contracts;

namespace IMS.Tutorial.Data.InMemoryPlugin;

public class InventoryRepository : IInventoryRepository
{
    private List<InventoryItem> _inventoryItems;

    public InventoryRepository()
    {
        var itemIds = 1;
        var inventoryItemFaker = new Faker<InventoryItem>()
            .RuleFor(i => i.Id, f => itemIds++)
            .RuleFor(i => i.Name, f => f.Commerce.ProductName())
            .RuleFor(i => i.Description, f => f.Commerce.ProductDescription())
            .RuleFor(i => i.Quantity, f => f.Random.Number(0, 100))
            .RuleFor(i => i.PurchasePrice, f => f.Random.Double(1, 100));


        _inventoryItems = Enumerable.Range(1, 10)
            .Select(CreateFromSeed)
            .ToList();

        InventoryItem CreateFromSeed(int seed)
        {
            return inventoryItemFaker.UseSeed(seed).Generate();
        }
    }

    public Task AddInventoryItemAsync(InventoryItem inventoryItem)
    {
        if (_inventoryItems.Any(item => item.Name.Equals(inventoryItem.Name, StringComparison.OrdinalIgnoreCase)))
            return Task.CompletedTask;

        inventoryItem.Id = _inventoryItems.Max(i => i.Id) + 1;
        _inventoryItems.Add(inventoryItem);

        return Task.CompletedTask;
    }

    public Task<InventoryItem> GetInventoryItemByIdAsync(int itemId)
    {
        var item = new InventoryItem( _inventoryItems.FirstOrDefault(_inventoryItems.First(item => item.Id.Equals(itemId))));
        return Task.FromResult(item);
    }

    public Task<IEnumerable<InventoryItem>> GetInventoryItemsByNameAsync(string name)
    {
        if (string.IsNullOrWhiteSpace(name)) return Task.FromResult(_inventoryItems.AsEnumerable());

        return Task.FromResult(_inventoryItems.Where(item => item.Name.Contains(name, StringComparison.OrdinalIgnoreCase)));
    }

    public Task UpdateAsync(InventoryItem inventoryItem)
    {
        if (_inventoryItems.Any(item => item.Id != inventoryItem.Id && item.Name.Equals(inventoryItem.Name)))
            return Task.CompletedTask;

        var updatedItem = _inventoryItems.FirstOrDefault(item => item.Id.Equals(inventoryItem.Id));
        if (updatedItem is not null)
        {
            updatedItem.Name = inventoryItem.Name;
            updatedItem.Quantity = inventoryItem.Quantity;
            updatedItem.PurchasePrice = inventoryItem.PurchasePrice;
            updatedItem.Description = inventoryItem.Description;
        }

        return Task.CompletedTask;
    }
}