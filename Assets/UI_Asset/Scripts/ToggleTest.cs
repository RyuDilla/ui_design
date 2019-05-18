using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleTest : MonoBehaviour
{
    //連携するGameObject
    public ToggleGroup toggleGroup;
    public IEnumerable<Toggle> toggles;
    public Toggle toggle;

    public void onClick()
    {
        toggles = toggleGroup.ActiveToggles();
        foreach(Toggle toggle in toggles)
        { 
            print(toggle.GetComponentInChildren<Text>().text);  
        }
    }
}
