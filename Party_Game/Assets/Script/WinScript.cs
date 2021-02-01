using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    public AudioClip collectedClip;

    public Text textObject;

    void OnTriggerStay2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            if (controller.score < controller.maxScore)
            {
                controller.ChangeScore(1);

                controller.PlaySound(collectedClip);
            }
        }
    }
}
