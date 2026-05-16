using System.Collections.Generic;

public class InventorySystem
{
    private List<InventoryItem> items;
    private int maxSlots;

    public InventorySystem(int maxSlots = 20)
    {
        this.maxSlots = maxSlots;
        items = new List<InventoryItem>();
    }

    public bool AddItem(InventoryItem item)
    {
        if (items.Count >= maxSlots)
            return false;

        items.Add(item);
        return true;
    }

    public bool RemoveItem(string itemId)
    {
        var item = items.Find(i => i.Id == itemId);
        if (item == null)
            return false;

        items.Remove(item);
        return true;
    }

    public List<InventoryItem> GetAllItems()
    {
        return new List<InventoryItem>(items);
    }
}

public class InventoryItem
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public ItemType Type { get; set; }
}

public enum ItemType
{
    Weapon,
    Armor,
    Consumable,
    Material
}
