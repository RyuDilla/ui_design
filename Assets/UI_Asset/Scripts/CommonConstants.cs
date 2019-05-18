using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CommonConstants
{
    public static class SceneName
    {
        public static readonly string Stage1 = "Stage1";
        public static readonly string Stage2 = "Stage2";
        public static readonly string Stage3 = "Stage3";
        public static readonly string MainUI = "MainUI";
        public static readonly string GameClearScene = "GameClearScene";
        public static readonly string GameOverScene = "GameOverScene";
    }

    public static List<string> stageList = new List<string>
    {
        CommonConstants.SceneName.Stage1,
        CommonConstants.SceneName.Stage2,
        CommonConstants.SceneName.Stage3
    };
}
