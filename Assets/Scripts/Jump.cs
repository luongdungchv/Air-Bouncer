using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Jump : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        StartCoroutine(TriggerJump());
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        StartCoroutine(TriggerJump());
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        InputManager.JumpTriggered = false;
    }
    IEnumerator TriggerJump()
    {
        InputManager.JumpTriggered = true;
        yield return null;
        InputManager.JumpTriggered = false;
    }
}
