using IMS.Tutorial.Contracts;

namespace IMS.Tutorial.UseCases.Inventory.Queries;

public interface IGetInventoryItemsByNameContaining
{
    Task<IEnumerable<InventoryItem>> ExecuteAsync(string name = "");
}

public class GetInventoryItemsByNameContaining : IGetInventoryItemsByNameContaining
{
    private readonly IInventoryRepository inventoryRepository;

    public GetInventoryItemsByNameContaining(IInventoryRepository inventoryRepository)
    {
        this.inventoryRepository = inventoryRepository;
    }

    public async Task<IEnumerable<InventoryItem>> ExecuteAsync(string name = "")
    {
        return await inventoryRepository.GetInventoryItemsByNameAsync(name);
    }
}
