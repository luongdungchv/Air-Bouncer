using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool IsStackable;
    public Sprite sprite;
    
    private void Start()
    {
        sprite = this.GetComponent<SpriteRenderer>().sprite;
    }
    private void OnMouseDown()
    {
        Inventory.ins.SetItem(this);
    }
}
