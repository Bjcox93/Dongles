using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class UI_overlay : MonoBehaviour {

    public static bool IsPointerOverUIObject()
    {
        Debug.Log("UI_OverLay1");
        PointerEventData eventDatatCurrentPosition = new PointerEventData(EventSystem.current);
        eventDatatCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDatatCurrentPosition, results);
        Debug.Log("UI_OverLay2");
        return results.Count > 0;
    }
}
