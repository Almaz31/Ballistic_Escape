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
        }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            GameManager.Instance.Lose();
            Debug.Log("Triggered Enemy");
        }
    }
}
