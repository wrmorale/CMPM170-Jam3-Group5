using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public Texture2D cursorTexture;

    public Transform playerPos;
    public Transform objectPos;


    /*void update(){
        if(playerPos){
            float dist = Vector3.Distance(playerPos.position, objectPos.position);
            Debug.Log("Distance to obj: "  + dist);
        }
        
    }*/


    void OnMouseOver(){
        /*
        add if statement for distance checking
        */
        float dist = Vector3.Distance(playerPos.position, objectPos.position);
        //Debug.Log("Distance to obj: "  + dist);
        if(dist <= 25f){
            //Debug.Log("Mouse is over GameObject.");
            Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        }else{
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        }
        
    }
    
    void OnMouseExit(){
        //Debug.Log("Mouse is no longer on GameObject.");
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
    }
}
