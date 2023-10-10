using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("WinPoint"))
        {
            GameManager.Instance.Win();
        }
        else if (other.CompareTag("EndPoint"))
        {
            GameManager.Instance.ShowWinUI();
            GetComponent<PlayerMovement>().StopPlayer();
        }
        else if (other.CompareTag("Enemy"))
        {
            GameManager.Instance.Lose();
            GetComponent<PlayerMovement>().StopPlayer();
        }

    }
}
