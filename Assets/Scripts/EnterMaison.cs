using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterMaison : MonoBehaviour
{   

    private LevelManager _levelManager;


     [SerializeField]
    private string NomNiveau;


    // Start is called before the first frame update
    void Start()
    {
        _levelManager =LevelManager.Instance;
    }

    private void OnTriggerEnter(Collider other)
    {
        _levelManager.LoadScene(NomNiveau);
    }
}
