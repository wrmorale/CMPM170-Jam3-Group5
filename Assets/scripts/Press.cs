using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Press : MonoBehaviour {
   int n;
   public void OnButtonPress(){
      n++;
      Debug.Log("Button clicked " + n + " times.");
   }
}
