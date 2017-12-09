using UnityEngine;
using System.Collections;
using System;
using System.Net;


public class skypeCall : MonoBehaviour {

	bool x = true;
	bool collided;

	IEnumerator OnTriggerEnter (Collider other)
	{
		Debug.Log ("aaaaaaaaaaa");
		collided = true;

		if (collided == true && x == true) {
			Debug.Log ("bbbbbb");
			yield return new WaitForSeconds(6);  
			Debug.Log ("ccccc");
			string link = "skype:+94768666603?call\">Call ANC Institute";
			Application.OpenURL(link);
			x = false;
		}


	}

	// Use this for initialization
	void Start () {
		Debug.Log ("aaxxa");
	}

	// Update is called once per frame
	void Update () {


	}

	void OnCollisionExit () {
		collided = false;
	}
}
