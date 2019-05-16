using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Slider userSlider;
    public Text sliderValue;

    // Start is called before the first frame update
    void Start()
    {
        sliderValue.text = string.Format("{0:F2}", userSlider.value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChanged()
    {
        sliderValue.text = string.Format("{0:F2}", userSlider.value);
    }
}
