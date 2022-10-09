using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float speed;

    

    public void OnPointerDown(PointerEventData eventData)
    {
        InputManager.xSpeed = -1;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        InputManager.xSpeed = 0;
    }
}
