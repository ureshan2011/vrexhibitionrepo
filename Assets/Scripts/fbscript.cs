using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Facebook.Unity;
using Facebook.MiniJSON;
using UnityEngine.SceneManagement;

public class fbscript : MonoBehaviour {

	public GameObject DialogLoggedIn;
	public GameObject DialogLoggedOut;
	public GameObject DialogUsername;
	public GameObject DialogProfilePicture;
	public static string user_name = "Anonymous";
	public static string user_email = "futureminds2017@gmail.com";

	public Image photo_base;
	public Text id_base;
	public Text fname_base;
	public Text lname_base;
	public Text gender_base;
	public Text email_base;

	void Awake(){
		FB.Init (SetInit, OnHideUnity);


	}

	void SetInit(){
		DontDestroyOnLoad (transform.gameObject);
		if (FB.IsLoggedIn) {
			Debug.Log ("Logged In");
		} else {
			Debug.Log ("Not Logged In");
		}
		fbmenus (FB.IsLoggedIn); 
	}

	void OnHideUnity(bool isGameShown){
		if (!isGameShown) {
			Time.timeScale=0;
		}else{
			Time.timeScale=1;
		}
	}

	public void FBLogin(){
		var perms = new List<string>(){"public_profile", "email", "user_friends"};
		FB.LogInWithReadPermissions (perms, AuthCallback);


	
	}

	void AuthCallback(ILoginResult  result){



		if (FB.IsLoggedIn)
		{

		}
		else
		{
			Debug.Log("User cancelled login");
		}


		if (FB.IsLoggedIn) {
			// AccessToken class will have session details
			var aToken = Facebook.Unity.AccessToken.CurrentAccessToken;
			// Print current access token's User ID
			Debug.Log(aToken.UserId);
			// Print current access token's granted permissions
			foreach (string perm in aToken.Permissions) {
				Debug.Log(perm);
			}

			// Make a Graph API call to get email address
		
		} else {
			Debug.Log("User cancelled login");
		}

		if (result.Error != null) {
			Debug.Log (result.Error);
		} else {
			if (FB.IsLoggedIn) {
				Debug.Log ("Logged In");

				Debug.Log ("email "+ email_base);

			} else {
				Debug.Log ("Not Logged In");
			}

			fbmenus (FB.IsLoggedIn);

		
		}
			
	}


	void fbmenus(bool isLoggedIn){
		if (isLoggedIn) {
			DialogLoggedIn.SetActive(true);
			DialogLoggedOut.SetActive(false);


			FB.API("/me?fields=id,first_name,last_name,email", HttpMethod.GET, graphCallback);
			FB.API ("/me/picture?type=square&height=128&width=128" , HttpMethod.GET, DisplayProfilepicture);


			SceneManager.LoadScene("main scene", LoadSceneMode.Additive);
			//Application.LoadLevel(1);


		} else {
			DialogLoggedIn.SetActive(false);
			DialogLoggedOut.SetActive(true);
		} 
	}


	void graphCallback(IGraphResult result)
	{
		Debug.Log("hi= "+result.RawResult);
		string id;
		string firstname;
		string lastname;
		string gender;
		string email;

	
		Debug.Log ("ssssss "+result.RawResult);
		user_name = result.ResultDictionary ["first_name"].ToString();
		user_email = result.ResultDictionary ["email"].ToString();
		Debug.Log (user_email);
		string[] lines = {user_name , user_email};
	
		System.IO.File.WriteAllLines("username.txt",lines);
		Debug.Log ("config created "+user_name);
	}

	void DisplayUsername(IResult result){
		if (DialogUsername != null ){
		Text UserName = DialogUsername.GetComponent<Text> ();
		

		if (result.Error != null ) {
			Debug.Log (result.Error);
		} else {
			UserName.text = "Hi there, " + result.ResultDictionary ["first_name"];
			user_name =  result.ResultDictionary ["first_name"].ToString();
		}
	}
	}

	void DisplayProfilepicture(IGraphResult result){
		DontDestroyOnLoad (transform.gameObject);
		if (result.Texture != null && DialogProfilePicture != null ) {
			Image ProfilePicture = DialogProfilePicture.GetComponent<Image> ();
			ProfilePicture.sprite = Sprite.Create (result.Texture, new Rect(0,0,128,128), new Vector2());
		} 
	}


}
