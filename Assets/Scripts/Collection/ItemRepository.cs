using System.Collections.Generic;
using System.Linq;

public class ItemRepository
{
    public static Dictionary<int, Item> _items;

    public static Item Get(int Id)
    {
        if (_items.ContainsKey(Id))
        {
            return _items[Id];
        }
        return null;
    }

    public static void LoadItems()
    {
        List<Item> item = getDataFromDatabase.GetItems();
        _items = item.ToDictionary(key => key.Id, value => value);
    }
}

public class getDataFromDatabase
{
    public static List<Item> GetItems()
    {
        List<Item> newItem = new List<Item>();
        return newItem;
    }
}
