using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallDoor : MonoBehaviour
{
    public AudioSource audio;

    void OnTriggerEnter(Collider coll){
        if(coll.tag=="Player"){
            GetComponent<Animator>().Play("Small Door");
            audio.Play();
        }
    }
}