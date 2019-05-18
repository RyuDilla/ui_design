using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("Gravity", 5.0f);
        PlayerPrefs.SetFloat("Size", 7.0f);

        if(PlayerPrefs.HasKey("Gravity"))
        {
            print(PlayerPrefs.GetFloat("Gravity"));
        }

        if(PlayerPrefs.HasKey("Size"))
        {
            print(PlayerPrefs.GetFloat("Size"));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
