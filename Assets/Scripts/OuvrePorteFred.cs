using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvrePOrteFRed : MonoBehaviour
{

    private Animator _animateurPorte;

    [SerializeField]
    private GameObject _porte;


    // Start is called before the first frame update
    void Start()
    {


        _animateurPorte = _porte.GetComponent<Animator>();
    }

   


    void OnTriggerEnter(Collider other)
    {

       _animateurPorte.SetTrigger("PorteFred");

    }


}
