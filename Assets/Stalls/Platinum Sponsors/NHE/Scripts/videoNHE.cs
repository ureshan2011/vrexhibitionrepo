using UnityEngine;
using System.Collections;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class videoNHE : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		Application.ExternalEval("window.open(\"https://www.youtube.com/watch?v=hTFD2rX3un8\")");
	}


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

}
