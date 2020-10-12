using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shuttleDoor : MonoBehaviour 
{
	public Animator left;
	public Animator right;
	public AudioSource audio;
	public Material material;
	public int error;
	Renderer rend;

	public void OnTriggerEnter(Collider other) {
		if(error == 0) {
			left.SetTrigger("Shuttle door - Close");
			right.SetTrigger("Shuttle door - Close");
			audio.Play();
			rend.sharedMaterial = material;
		}
	}

	void Update() {
		rend = GetComponent<Renderer>();
		rend.enabled = true;

		if(error != 0) {
			rend.sharedMaterial = material;

			if(error == 1) {
				left.SetTrigger("Shuttle door - Close");
				right.SetTrigger("Shuttle door - Close");
			}

			if(error == 2) {
				left.SetTrigger("Shuttle door - error 2");
				right.SetTrigger("Shuttle door - error 2");
				audio.Play();
			}

			if(error == 3) {
				
			}
		}
	}
}