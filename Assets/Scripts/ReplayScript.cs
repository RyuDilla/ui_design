using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayScript : MonoBehaviour
{
    public void Replay(){
        SceneController.Instance.ReplayStage();
    }
}
