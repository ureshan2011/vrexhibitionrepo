using UnityEngine;
using System.Collections;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class triggerScript : MonoBehaviour {


	void OnTriggerEnter (Collider other)
	{
		


		//email_send ();



	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void email_send(){
		MailMessage mail = new MailMessage();
		mail.From = new MailAddress("noreply@vexpo.futureminds.lk");
		mail.To.Add("futuremindsnalandavr@gmail.com");
		mail.Subject = "Your Future Minds Expo Virtual Stall has a Visitor";
		mail.Body = "A user with yasas@gmail.com has visited to your virtual exhibition stall. Visitor's Contact Number is 0768666603";

		SmtpClient smtp = new SmtpClient("smtp.gmail.com");
		smtp.Port = 587;
		smtp.Credentials = new System.Net.NetworkCredential("futuremindsnalandavr@gmail.com", "futuremindsnalanda") as ICredentialsByHost;
		smtp.EnableSsl = true;

		ServicePointManager.ServerCertificateValidationCallback =
			delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) {
			return true;
		};
		smtp.Send(mail);
		//smtp.SendAsync(mail,null);
		Debug.Log("success");
	}
}
