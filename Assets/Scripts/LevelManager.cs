using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

     private int sceneIndex;
    
    public static LevelManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
                Instance = this;
                DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

         
    }

    private void Update(){
            sceneIndex = SceneManager.GetActiveScene().buildIndex;

    }

  public void LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void LoadNewGame()
    {
        LoadScene("Level01");
    }

    public void LoadMainMenu()
    {
        LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        
        Application.Quit();
        
    }


    public void NextScene(){

        SceneManager.LoadScene(sceneIndex + 1);
    }
}
