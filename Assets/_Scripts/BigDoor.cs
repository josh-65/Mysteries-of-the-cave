using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDoor : MonoBehaviour 
{
	public Animator left;
	public Animator right;
	public AudioSource audio;
	public AudioClip playAudio;

	public void OnTriggerEnter(Collider other) {
		left.SetTrigger("Big Door - Open");
		right.SetTrigger("Big Door - Open");
		audio.PlayOneShot(playAudio);
	}
}