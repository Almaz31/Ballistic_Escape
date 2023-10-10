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
            Debug.Log("WinPoint");
        }
        else if (other.CompareTag("EndPoint"))
        {
            GameManager.Instance.ShowWinUI();
        }
    }
}
