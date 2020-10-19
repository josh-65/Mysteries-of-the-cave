using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigDoor : MonoBehaviour 
{
	public Animator left;
	public Animator right;
	public AudioSource audio;
	public bool enabled;

	public void OnTriggerEnter(Collider other) {
		if(enabled) {
			left.SetTrigger("Big Door - Open");
			right.SetTrigger("Big Door - Open");
			audio.Play();
		}
	}
}