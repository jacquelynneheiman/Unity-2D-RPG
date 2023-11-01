using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public Dictionary<string, Inventory> inventoryByName = new Dictionary<string, Inventory>();

    [Header("Backpack")]
    public Inventory backpack;
    public int backpackSlotsCount = 27;

    [Header("Toolbar")]
    public Inventory toolbar;
    public int toolbarSlotsCount = 9;


    private void Awake()
    {
        backpack = new Inventory(backpackSlotsCount);
        toolbar = new Inventory(toolbarSlotsCount);

        inventoryByName.Add("backpack", backpack);
        inventoryByName.Add("toolbar", toolbar);
    }

    public Inventory GetInventoryByName(string name)
    {
        if (inventoryByName.ContainsKey(name))
        {
            return inventoryByName[name];
        }

        return null;
    }

    public void Add(string inventoryName, Item item)
    {
        if (inventoryByName != null)
        {
            if (inventoryByName.ContainsKey(inventoryName))
            {
                inventoryByName[inventoryName].Add(item);
            }
        }
    }
}
