using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    #region Public Variables
    public GameObject optionScreen;
    public GameObject labScreen;
    public GameObject startScreen;
    public GameObject selectScreen;
    public GameObject mainMenuScreen;
    public GameObject creditScreen;
    public Animator menuAnimator;
    #endregion

    #region Private Variables
    private int curScreenID;
    #endregion
    
    #region UI Actions
    public void SwitchScreen(int screenID)
    {
        SetMenuState(false);
        switch(screenID)
        {
            case 0:
                startScreen.gameObject.SetActive(true);
                break;
            case 1:
                SetMenuState(true);
                mainMenuScreen.gameObject.SetActive(true);
                break;
            case 2:
                selectScreen.gameObject.SetActive(true);
                break;
            case 3:
                optionScreen.gameObject.SetActive(true);
                break;
            case 4:
                creditScreen.gameObject.SetActive(true);
                break;
            default:
                break;
        }
    }

    private void SetMenuState(bool isActive)
    {
        if(menuAnimator)
        {
            menuAnimator.SetBool("isActive", isActive);
        }
    }
    #endregion
}
