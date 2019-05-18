using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectController : MonoBehaviour
{
    public Image stageImage;
    public List<Sprite> stageSpriteList;
    public Sprite defaultSprite;
    public ToggleGroup toggleGroup;
    private IEnumerable<Toggle> toggles;
    public string selectedStageName;

    // Start is called before the first frame update
    void Start()
    {
        stageImage.sprite = defaultSprite;
    }

    void Update()
    {
        //UpdateImage();
    }

    public void StartGame()
    {
        int selectedStageIdx = GetActiveToggle();
        // シーンの制御はシーンコントローラーに委譲
        SceneController.Instance.StartGame(selectedStageIdx);
    }

        public void UpdateImage()
    {
        int spriteIdx = GetActiveToggle();
        stageImage.sprite = stageSpriteList[spriteIdx - 1];
    }

    public int GetActiveToggle()
    {
        toggles = toggleGroup.ActiveToggles();
        foreach(Toggle toggle in toggles)
        {
            selectedStageName = toggle.name;
        }
        int idx = 0;
        // ステージ名をインデックスに変換
        switch(selectedStageName)
        {
            case "Stage1":
                idx = 1;
                break;

            case "Stage2":
                idx = 2;
                break;

            case "Stage3":
                idx = 3;
                break;
            
            default:
                break;
        }

        return idx;
    }
}
