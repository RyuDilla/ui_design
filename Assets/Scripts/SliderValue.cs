﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{

    public Slider userSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateSliderValue()
    {
        if(userSlider)
        {
            Debug.Log(userSlider.value);
            PlayerPrefs.SetFloat("Gravity", userSlider.value);
            print("Gravity : " + PlayerPrefs.GetFloat("Gravity"));
        }
    }
}
