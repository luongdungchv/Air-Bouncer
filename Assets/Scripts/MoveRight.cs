using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveRight : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    public void OnPointerDown(PointerEventData eventData)
    {
        InputManager.xSpeed = 1;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        InputManager.xSpeed = 0;
    }
}
