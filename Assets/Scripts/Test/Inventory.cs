using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory ins;
    public Transform inventoryPanel;
    public ItemButton btnPrefab;
    public Dictionary<Item, ItemButton> inventoryBag;

    private void Start()
    {
        ins = this;
        inventoryBag = new Dictionary<Item, ItemButton>();
    }

    public void SetItem(Item i)
    {
        if (i.IsStackable)
        {
            if (inventoryBag.ContainsKey(i))
            {
                inventoryBag[i].quantity++;
                inventoryBag[i].transform.GetChild(0).GetComponent<Text>().text = inventoryBag[i].quantity.ToString();
                return;
            }
            else
            {
                var btn = Instantiate(btnPrefab);
                btn.quantity = 1;
                inventoryBag.Add(i, btn);
                btn.transform.SetParent(inventoryPanel);
                return;
            }
        }
        var button = Instantiate(btnPrefab);
        button.transform.SetParent(inventoryPanel);
    }

}
