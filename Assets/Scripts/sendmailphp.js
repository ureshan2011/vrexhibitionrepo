#pragma strict
var URL = "https://nalandavrexpo.000webhostapp.com/sendemail.php"; //change for your URL

function Start () {

}

function Update () {
	
}
function OnTriggerEnter(otherObj: Collider){

		Debug.Log ("abc");
		var form = new WWWForm(); //here you create a new form connection
		form.AddField( "object","You Have a Visitor!"); //add your hash code to the field myform_hash, check that this variable name is the same as in PHP file
		form.AddField("text","An User with yasas@gmail.com has visited to your virtual exhibition stall. Visitor's Contact Number is 0768666603");
		form.AddField("email","noreply@vexpo.futureminds.lk");
		var w = WWW(URL, form); //here we create a var called 'w' and we sync with our URL and the form
		Debug.Log ("a");

}