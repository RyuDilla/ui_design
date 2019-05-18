using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : SingletonMonoBehaviour<SceneController>
{
    public int sID;
    public string selectedStageName;

    // Start is called before the first frame update
    void Start()
    {
        // シーン間を移動してもこのオブジェクトは破棄しないようにする
        DontDestroyOnLoad(this.gameObject);
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene(CommonConstants.SceneName.MainUI);
    }

    public void GoGameClear()
    {
        SceneManager.LoadScene(CommonConstants.SceneName.GameClearScene);
    }

    public void GoGameOver()
    {
        SceneManager.LoadScene(CommonConstants.SceneName.GameOverScene);
    }

    public void StartGame(int idx)
    {
        sID = idx;
        SceneManager.LoadScene(idx);
    }

    public void ReplayStage()
    {   
        print("current_sID:" + sID);
        SceneManager.LoadScene(sID);
    }
}
