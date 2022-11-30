using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    public float radius = 1;
    KeyManager keyScript;

    void Start()
    {
        keyScript = GameObject.FindGameObjectWithTag("KeyManager").GetComponent<KeyManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach(Collider nearbyObject in colliders)
        {
            if(nearbyObject.tag == "Key1")
            {
                keyScript.FoundKey1(true);
            }
            if(nearbyObject.tag == "Key2")
            {
                keyScript.FoundKey2(true);
            }
            if(nearbyObject.tag == "Key3")
            {
                keyScript.FoundKey3(true);
            }
        }
        this.enabled = false;
    }
}
