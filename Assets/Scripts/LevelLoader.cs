using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour
{

    public static LevelLoader instance;
    int CurrentSceneIndex;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(CurrentSceneIndex == 0)
        {  
            StartCoroutine(WaitForTime());
        }
   
    }
    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(2f);
        LoadNextScene();
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
