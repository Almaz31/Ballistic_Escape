using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseUI : MonoBehaviour
{
    [SerializeField] private Button homeButton;
    [SerializeField] private Button restartButton;
    void Start()
    {
        homeButton.onClick.AddListener(() =>
        {
            GameManager.Instance.Home();
        });
        restartButton.onClick.AddListener(() =>
        {
            GameManager.Instance.Restart();
        });
    }

}
