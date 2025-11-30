using UnityEngine;
using UnityEngine.EventSystems;

public class HeldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isHeld;

    public void OnPointerDown(PointerEventData eventData)
    {
        isHeld = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isHeld = false;
    }
}
