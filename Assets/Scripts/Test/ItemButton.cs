using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    Button btn;
    public Item item;
    public int quantity;
    private void Start()
    {
        btn = GetComponent<Button>();
    }
}
