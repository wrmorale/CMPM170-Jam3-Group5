using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public Texture2D cursorTexture;



    void OnMouseOver(){
        Debug.Log("Mouse is over GameObject.");
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
    }
    
    void OnMouseExit(){
        Debug.Log("Mouse is no longer on GameObject.");
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}
