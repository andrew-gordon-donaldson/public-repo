using IMS.Tutorial.Contracts;

namespace IMS.Tutorial.UseCases.Inventory.Queries;

public interface IGetInventoryItemById
{
    Task<InventoryItem> ExecuteAsync(int itemId);
}

public class GetInventoryItemById : IGetInventoryItemById
{
    private readonly IInventoryRepository _inventoryRepository;

    public GetInventoryItemById(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }

    public Task<InventoryItem> ExecuteAsync(int itemId)
    {
        return _inventoryRepository.GetInventoryItemByIdAsync(itemId);
    }
}
