using IMS.Tutorial.Contracts;

namespace IMS.Tutorial.UseCases.Inventory.Commands;

public interface IUpdateInventoryItemCommand
{
    Task ExecuteAsync(InventoryItem inventoryItem);
}

public class UpdateInventoryItemCommand : IUpdateInventoryItemCommand
{
    private readonly IInventoryRepository _inventoryRepository;

    public UpdateInventoryItemCommand(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }

    public Task ExecuteAsync(InventoryItem inventoryItem)
    {
        return _inventoryRepository.UpdateAsync(inventoryItem);

    }
}