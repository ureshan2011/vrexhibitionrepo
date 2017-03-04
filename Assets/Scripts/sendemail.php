 <?php
 // Pick up the form data and assign it to variables
 $object = $_POST['object'];
 $text= $_POST['text'];
 $email = $_POST['email'];
 
 
 $to='futuremindsnalandavr@gmail.com';
 $subject="$object";
 $message="$text";
 $headers = "From: $email";
 
 // Send the mail using PHPs mail() function
 mail($to, $subject, $message, $headers);
 ?>