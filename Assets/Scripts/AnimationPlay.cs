using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlay : MonoBehaviour
{

    public InfosNiveaux _infosNiv;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && _infosNiv.nb_points == 2)
        {
            anim.SetTrigger("PlayerTouch");
        }
    }
   
    


}
