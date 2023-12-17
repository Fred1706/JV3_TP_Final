using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneFinTransition : MonoBehaviour
{


 
    [SerializeField] private string sceneNameToLoad;


 public void StartNewGame()
    {
    
     

        Invoke("DelayScene", 8);

      

    }

   public void DelayScene()
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }




}
