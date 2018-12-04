using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Hover : MonoBehaviour {

    //ColourMouse
    //When the mouse hovers over the GameObject, it turns to this color (red)
    public Color m_MouseOverColor = Color.red;

    //This stores the GameObject’s original color
    public Color m_OriginalColor;

    //Get the GameObject’s mesh renderer to access the GameObject’s material and color
    public MeshRenderer m_Renderer;

    private void Start()
    {
        //When the mouse hovers over the GameObject, it turns to this color (red)
        Color m_MouseOverColor = Color.red;

        //This stores the GameObject’s original color
        m_Renderer = GetComponent<MeshRenderer>();
       m_OriginalColor = m_Renderer.material.color;

        //Get the GameObject’s mesh rende
    }


    void OnMouseOver()
    {
        
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");

        // Change the color of the GameObject to red when the mouse is over GameObject
        m_Renderer.material.color = m_MouseOverColor;
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");

        // Reset the color of the GameObject back to normal
        m_Renderer.material.color = m_OriginalColor;
    }
}
