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
        SceneManager.LoadScene(SceneManager.GetActiveScene().ToString());
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(2).ToString());
    }
    public void ShowWinUI()
    {
        WinUI.SetActive(true);
    }
}
