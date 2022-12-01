using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyManager : MonoBehaviour
{
    public Dictionary<int,bool> keys = new Dictionary<int,bool>();
    
    void Start()
    {
        keys.Add(1,false);
        keys.Add(2,false);
        keys.Add(3,false);
    }

    // Update is called once per frame
    void Update()
    {
        if (keys[1] && keys[2] && keys[3])
        {
            //SceneManager.LoadScene("PrototypeScene");
            Debug.Log("Success");
        }
    }

    public bool FoundKey1(bool key)
    {
        if (key)
        {
            keys[1]=true;
        }
        return true;
    }

    public bool FoundKey2(bool key)
    {
        if (key)
        {
            keys[2]=true;
        }
        return true;
    }

    public bool FoundKey3(bool key)
    {
        if (key)
        {
            keys[3]=true;
        }
        return true;
    }

}
