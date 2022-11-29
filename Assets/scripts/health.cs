using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class health : MonoBehaviour
{
    public float curHealth = 0;
    public int maxHealth = 100;
    private Slider slider;
    public float max = 0;
    public float speed = 0.5f;

    private void Awake(){
        slider = gameObject.GetComponent<Slider>();
    }

    void Start()
    {
        curHealth =  increment(0.33f, 1);
        curHealth = increment(0.33f, 2);
    }

    void Update()
    {
        if( slider.value < max )
        {
            slider.value += speed * Time.deltaTime;
        }
    }

    public float increment(float progress, int ct){
        if (ct == 1 ){
            max = slider.value + progress;
            slider.value = max;
        }
        if (ct == 2){
            max = slider.value + progress;
        }
        return max;
    }
}
