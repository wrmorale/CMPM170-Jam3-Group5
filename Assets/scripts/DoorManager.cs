using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorManager : MonoBehaviour
{
    public GameObject door;
    public bool orientation; //false left - true right 
    public Transform playerPos;
    public Transform doorPivot;
    bool open = false;


    void OnMouseOver(){
        float dist = Vector3.Distance(playerPos.position, doorPivot.position);
        Debug.Log("Distance to obj: "  + dist);
        if(dist <= 25f && open == false){
            Debug.Log("Mouse is over GameObject.");

                if(Input.GetMouseButton(0)){
                    Debug.Log("Mouse Down");
                    Vector3 pivotPoint = doorPivot.position;
                    if(orientation == false){
                        transform.RotateAround(pivotPoint, Vector3.up, 90);
                        open = true;
                    }else if(orientation == true){
                        transform.RotateAround(pivotPoint, Vector3.up, 270);
                        open = true;
                    }
                    
                }
        }else if(dist <= 25f && open == true){
            Debug.Log("Mouse is over GameObject.");

                if(Input.GetMouseButton(0)){
                    Debug.Log("Mouse Down");
                    Vector3 pivotPoint = doorPivot.position;
                    if(orientation == false){
                        transform.RotateAround(pivotPoint, Vector3.up, -90);
                        open = false;
                    }
                    if(orientation == true){
                        transform.RotateAround(pivotPoint, Vector3.up, -270);
                        open = true;
                    }
                    
                }
        }
    }
    
    


}
