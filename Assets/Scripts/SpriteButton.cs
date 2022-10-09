using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class SpriteButton : MonoBehaviour
{
    [SerializeField]
    public UnityAction OnClick;

    public void AddListener(UnityAction action)
    {
        OnClick = action;
    }
    private void OnMouseDown()
    {
        OnClick();
    }
}
