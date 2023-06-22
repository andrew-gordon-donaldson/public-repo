using IMS.Tutorial.Contracts;

namespace IMS.Tutorial.UseCases.Inventory.Commands;

public interface IAddInventoryItemCommand
{
    Task ExecuteAsync(InventoryItem inventoryItem);
}

public class AddInventoryItemCommand : IAddInventoryItemCommand
{
    private readonly IInventoryRepository _inventoryRepository;

    public AddInventoryItemCommand(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }

    public Task ExecuteAsync(InventoryItem inventoryItem)
    {
        return _inventoryRepository.AddInventoryItemAsync(inventoryItem);
    }
}
