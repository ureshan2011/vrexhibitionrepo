using UnityEngine;
using System.Collections;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class videoANC : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
				Application.ExternalEval("window.open(\"https://www.youtube.com/watch?v=DnHR1tJ7bkA\")");
	}


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

}
