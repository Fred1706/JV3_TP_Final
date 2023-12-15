using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class outroSceneManager : MonoBehaviour
{

    [SerializeField] Button _newGame;

    private LevelManager _levelManager;

    // Start is called before the first frame update
    void Start()
    {
        _levelManager = LevelManager.Instance;

        _newGame.onClick.AddListener(StartNewGame);

    }

    // Update is called once per frame
    private void StartNewGame()
    {
        // _levelManager.LoadNewGame();

        _levelManager.LoadScene("Accueil");

    }


    private void QuitGame()
    {
        _levelManager.QuitGame();
    }


}
