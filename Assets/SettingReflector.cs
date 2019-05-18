using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingReflector : MonoBehaviour
{
    public GameObject ball;

    [SerializeField] float gravityScale;
    [SerializeField] float lifeStock;
    [SerializeField] float ballSize;
    [SerializeField] float ballFriction;

    private List<string> optionNameList = new List<string>{
        "GravityScale",
        "LifeStock",
        "BallSize",
        "BallFriction"
    };

    private Dictionary<string, float> settingDict;

    // Start is called before the first frame update
    void Start()
    {
        // 各設定値の取得
        gravityScale = PlayerPrefs.GetFloat("GravityScale");
        lifeStock = PlayerPrefs.GetFloat("LifeStock");
        ballSize = PlayerPrefs.GetFloat("BallSize");
        ballFriction = PlayerPrefs.GetFloat("BallFriction");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
