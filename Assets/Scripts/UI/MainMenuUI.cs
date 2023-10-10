using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button startButoon;
    private void Start()
    {
        startButoon.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Level1");
        });
    }
}
