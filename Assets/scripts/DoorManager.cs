using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorManager : MonoBehaviour
{
    public GameObject door;
    public bool orientation; //false left - true right 
    public Transform playerPos;
    public Transform doorPos;
    bool open = false;


    void OnMouseOver(){
        float dist = Vector3.Distance(playerPos.position, doorPos.position);
        Debug.Log("Distance to obj: "  + dist);
        if(dist <= 25f && open == false){
            Debug.Log("Mouse is over GameObject.");

                if(Input.GetMouseButton(0)){
                    Debug.Log("Mouse Down");
                    Vector3 pivotPoint = doorPos.position;
                    transform.RotateAround(pivotPoint, Vector3.up, 90);
                    open = true;
                }
        }else if(dist <= 25f && open == true){
            Debug.Log("Mouse is over GameObject.");

                if(Input.GetMouseButton(0)){
                    Debug.Log("Mouse Down");
                    Vector3 pivotPoint = doorPos.position;
                    transform.RotateAround(pivotPoint, Vector3.up, -90);
                    open = false;
                }
        }
    }
    
    


}
