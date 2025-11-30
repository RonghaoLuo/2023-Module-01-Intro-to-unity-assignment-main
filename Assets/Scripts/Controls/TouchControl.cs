using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchControl : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private RectTransform leftButton, rightButton;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("pointer is down on " + eventData.pointerPress);
        //if (eventData.pointerPress == leftButton)
        //{
        //    Debug.Log("Left Button Pressed");
        //    // Implement left movement logic here
        //}
        //else if (eventData.pointerPress == rightButton)
        //{
        //    Debug.Log("Right Button Pressed");
        //    // Implement right movement logic here
        //}
    }
}
