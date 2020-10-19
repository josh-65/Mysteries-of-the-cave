using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactorMeltdown : MonoBehaviour
{
    Renderer rend;
    public Material white;
    public Material red;
    public Animator redLight;
    public Light LightSource;
    public AudioSource audio;
    public bool test;

    void Start() {
        rend = GetComponent<Renderer>();
        LightSource = GetComponent<Light>();
		rend.enabled = true;

        rend.sharedMaterial = white;
        redLight.SetBool("on", false);
        //LightSource.color = Color.white;

        if(test) {
            meltdown();
        }

    }

    public void meltdown() {
        rend.sharedMaterial = red;
        redLight.SetBool("on", true);
        //LightSource.color = Color.red;
        audio.Play();
    }
}
