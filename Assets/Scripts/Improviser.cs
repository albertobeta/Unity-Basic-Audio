using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Improviser : MonoBehaviour {
	
	AudioSource _audio; 

	// Example: pentatonic blues scale: some semitones changes from a C
	// 2, 4, 10, 11, 18, 19, 21, 26, 28
	public int[] semitones;

	void Start () {

		_audio = GetComponent<AudioSource>();

	}
	
	void Update () {
	
		if (Input.GetKeyDown("space")) {

			PlayNote();

		}
	}


	void PlayNote() {

		float randomSemitone = semitones[Random.Range(0, semitones.Length)];
		_audio.pitch = Mathf.Pow (2f, randomSemitone/12.0f);
		_audio.Play ();
		Debug.Log("Bliiing (" +randomSemitone+ ")");

	}

}
