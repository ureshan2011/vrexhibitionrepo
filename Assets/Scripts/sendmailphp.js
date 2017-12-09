#pragma strict
var URL = "http://vexpo.futureminds.lk/vrexhibition/sendemail.php"; //change for your URL

function Start () {

}

function Update () {
	
}
function OnTriggerEnter(otherObj: Collider){

		Debug.Log ("abc");
		var form = new WWWForm(); //here you create a new form connection
		form.AddField( "object","You Have a Visitor! || Virtual Expo "); //add your hash code to the field myform_hash, check that this variable name is the same as in PHP file
		form.AddField("text","An User with _name_of_user has visited to your virtual exhibition stall. Visitor's Contact Number is _mobile_number_of_user");
		form.AddField("email","noreply@vexpo.futureminds.lk");
		var w = WWW(URL, form); //here we create a var called 'w' and we sync with our URL and the form
		Debug.Log ("a");

}