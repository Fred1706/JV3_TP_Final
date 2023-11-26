using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartieTrouvé : MonoBehaviour
{
    [SerializeField]
    private InfosNiveaux _infosNiv;

    public void AddPart()
    {
        Destroy(gameObject);

        _infosNiv.nb_points++;
    }
}
