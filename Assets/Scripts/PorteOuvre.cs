using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteOuvre : MonoBehaviour
{
    [SerializeReference] private Animator myDoor;

    public void OuvrePorte()
    {
        myDoor.SetBool("DoorOpen", true);
    }
}
