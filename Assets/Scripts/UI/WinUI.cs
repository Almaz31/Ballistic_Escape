using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinUI : MonoBehaviour
{
    [SerializeField] private Button homeButton;
    [SerializeField] private Button restartButton;
    [SerializeField] private Button nextLevelButton;
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
        nextLevelButton.onClick.AddListener(() =>
        {
            GameManager.Instance.NextLevel();
        });
    }

}
