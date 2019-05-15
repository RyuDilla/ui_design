using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Goal":
                print("GameClear");
                SceneController.Instance.GoGameClear();
                break;

            case "DeadLine":
                print("You Are dead");
                SceneController.Instance.GoGameOver();
                break;

            default:
                break;
        }
    }
}
