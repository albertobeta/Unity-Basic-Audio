using UnityEngine;
using System.Collections;

public class bouncingBall : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {

		Debug.Log("Collision");

		GetComponent<AudioSource>().Play();

	}

}
