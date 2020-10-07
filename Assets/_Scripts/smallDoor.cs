using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallDoor : MonoBehaviour {

    void OnTriggerEnter(Collider coll){
        if(coll.tag=="Player"){
            GetComponent<Animator>().Play("Small Door");
        }
    }
}