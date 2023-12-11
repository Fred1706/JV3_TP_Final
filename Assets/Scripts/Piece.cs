using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Piece : MonoBehaviour
{

    [SerializeField]
    private InfosNiveaux _infosNiv;


    [SerializeField] private TMP_Text _partie;
    // Start is called before the first frame update
    void Start()
    {
        _partie.text = "pieces trouvé " + _infosNiv.nb_points + "/2";


    }

    // Update is called once per frame
    void Update()
    {

        if(_infosNiv.nb_points > 0)
        {
            _partie.text = "pieces trouvé " + _infosNiv.nb_points + "/2";
        }
       
    }
}
