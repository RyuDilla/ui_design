using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefGetOnly : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        print(PlayerPrefs.GetFloat("Gravity"));
        print(PlayerPrefs.GetFloat("Size"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
