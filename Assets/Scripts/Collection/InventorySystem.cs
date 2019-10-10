using System.Collections.Generic;
using System.Linq;

public class InventorySystem
{
    private Stack<Item> _overFlowItem = new Stack<Item>();
    //private Queue<Item> _overFlowItem = new Queue<Item><Item>();
    private Dictionary<int, Item> _itemInSlot = new Dictionary<int, Item>();

    private int _slotAvailable = 10;


    public void AddItem(Item item)
    {
        for (int i = 0; i < _slotAvailable; i++)
        {
            if(_itemInSlot.ContainsKey(i) == false ||
                _itemInSlot[i] == null)
            {
                _itemInSlot[i] = item;
                return;
            }
            _overFlowItem.Push(item);
            //_overFlowItem.Enqueue(item);
        }
    }

    public void DeleteItem(int slot)
    {
        if (_itemInSlot.ContainsKey(slot) ||
             _itemInSlot[slot] != null)
        {
            _itemInSlot[slot] = _overFlowItem.Any() ? _overFlowItem.Pop() : null;
            //_itemInSlot[slot] = _overFlowItem.Any() ? _overFlowItem.Dequeue() : null;
        }
    }
}
