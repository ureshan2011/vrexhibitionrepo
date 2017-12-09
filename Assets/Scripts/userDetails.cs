using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Facebook.Unity;


public class userDetails : MonoBehaviour {

	public static string userName;


	void OnGUI ()
	{
		userName = fbscript.user_name;
		GUI.Label (new Rect (0, 0, 100, 20), userName);

	}
}
