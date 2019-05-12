using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectController : MonoBehaviour
{
    public int selectedStageID;
    private Image stageImage;
    public List<Sprite> stageSpriteList;

    private string[] sceneArray = {"Stage1", "Stage2", "Stage3"};

    // Start is called before the first frame update
    void Start()
    {
        GameObject childObject = gameObject.transform.Find("StageImage").gameObject;
        stageImage = childObject.GetComponent<Image>();
        stageImage.sprite = stageSpriteList[0];
    }

    public void SetStageID(int stageID)
    {
        this.selectedStageID = stageID;
        stageImage.sprite = stageSpriteList[stageID];
    }

    public void StartGame()
    {
        SceneManager.LoadScene(sceneArray[selectedStageID - 1]);
    }
}
