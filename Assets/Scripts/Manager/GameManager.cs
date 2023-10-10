using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get;private set; }
    [SerializeField] private GameObject LoseUI;
    [SerializeField] private GameObject WinUI;
    [SerializeField] private WinAnimation winAnim;
    private void Start()
    {
        if(Instance == null)Instance = this;
    }
    public void Lose()
    {
        LoseUI.SetActive(true);
    }
    public void Win()
    {
        winAnim.StartAnimation();
    }
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
    public void ShowWinUI()
    {
        WinUI.SetActive(true);
    }
}
