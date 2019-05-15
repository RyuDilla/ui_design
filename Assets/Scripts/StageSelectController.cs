using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectController : MonoBehaviour
{
    public int selectedStageIdx;
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

    public void StartGame()
    {
        toggles = toggleGroup.ActiveToggles();
        foreach(Toggle toggle in toggles)
        {
            selectedStageName = toggle.name;
        }

        // ステージ名をインデックスに変換
        switch(selectedStageName)
        {
            case "Stage1":
                selectedStageIdx = 0;
                break;

            case "Stage2":
                selectedStageIdx = 1;
                break;

            case "Stage3":
                selectedStageIdx = 2;
                break;

        }
        // シーンの制御はシーンコントローラーに委譲
        SceneController.Instance.StartGame(selectedStageIdx);
    }
}
