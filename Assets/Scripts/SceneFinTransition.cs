using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneFinTransition : MonoBehaviour
{

 

    // Start is called before the first frame update
    void Start()
    {
       

   

    }

    // Update is called once per frame
    public void StartNewGame()
    {
        Invoke("scene-outro-menu", 15f);
        //SceneManager.LoadScene("scene-outro-menu");

    }





}
