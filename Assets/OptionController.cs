using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour
{

    public List<GameObject> sliderObjects;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateSettings()
    {
        // スライダーの名前と値をPlayerPrefに詰める
        foreach(GameObject obj in sliderObjects)
        {
            Slider slider = obj.GetComponentInChildren<Slider>();
            PlayerPrefs.SetFloat(obj.name, slider.value);
            print( obj.name + " : " + PlayerPrefs.GetFloat(obj.name));
        }
    }
}
