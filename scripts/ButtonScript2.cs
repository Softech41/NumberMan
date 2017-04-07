using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonScript2 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool Ispressed;


    public void OnPointerDown(PointerEventData touch)
    {
        Ispressed = true;
    }


    public void OnPointerUp(PointerEventData touch)
    {
        Ispressed = false;

    }
}
