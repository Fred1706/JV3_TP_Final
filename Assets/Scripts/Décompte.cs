using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class Décompte : MonoBehaviour
{
  

    [SerializeField]
    private InfosNiveaux _infosNiv;
   

    [SerializeField] private TMP_Text _temps;


   




    // Start is called before the first frame update
    void Start()
    {

       
       
    }
      



    // Update is called once per frame
    void Update()
    {
        _infosNiv.temps += Time.deltaTime;

        Afficher();
    }

    public void Afficher()
    {
       




        TimeSpan ts = TimeSpan.FromSeconds(_infosNiv.temps);

        //00:00:00:000
        _temps.text = string.Format("{0:00}:{1:00}:{2:00}:{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);

        
    }

   
}
