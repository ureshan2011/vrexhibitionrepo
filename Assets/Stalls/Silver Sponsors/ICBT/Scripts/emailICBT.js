import System.IO;
import System;

#pragma strict


var URL = "http://vexpo.futureminds.lk/vrexhibition/sendemail.php"; //change for your URL

var filePath = "username.txt";
var user_name = "Public User";
var user_email = "futureminds2017@gmail.com";
function Start () {

}

function Update () {
	
}


function OnTriggerEnter(otherObj: Collider){

        
		var form = new WWWForm(); //here you create a new form connection
		ReadFile(filePath);
		form.AddField( "object","You Have A New Visitor! || Virtual Expo"); //add your hash code to the field myform_hash, check that this variable name is the same as in PHP file
		form.AddField("text","[Notification] "+user_name+" Visited to Your Virtual Exhibition Stall. Visitor's Email Address is: "+user_email);
		form.AddField("email","noreply@vexpo.futureminds.lk");
		var w = WWW(URL, form); //here we create a var called 'w' and we sync with our URL and the form
		Debug.Log("JS "+user_name+ " and "+user_email);
}

function ReadFile(filepathIncludingFileName : String) {
     var sr = new File.OpenText(filepathIncludingFileName);
     var input = "";
     for(var i = 0 ; i < 2 ; ++i){
     	input = sr.ReadLine();
     	if (input == null) { break; Debug.Log("    no data"); }
     	if (i == 0) { user_name = input; Debug.Log("i = 0 username read "+user_name); }
     	if (i == 1) { user_email = input; Debug.Log("i = 1 email "+user_email); }
     	Debug.Log("file read");
     }

    sr.Close();
}

//function ReadFile2(filepathIncludingFileName : String) {
//    var sr2 = new File.OpenText(filepathIncludingFileName);
// 
//    var input2 = "";
//    while (true) {
//        input2 = sr2.ReadLine();
//        if (input2 == null) { break; }
//        Debug.Log("line="+input2);
//        user_email=input2;
//    }
//    sr2.Close();
//}

