<html>
 <head>
		<script src="//ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
		<style>
        body {
            font-family: Arial, sans-serif, Tahoma;
        }
		</style>
		<title>Medelinked API Test</title>
	</head>
 <body>
<?php
$providerKey = "ProviderKey";
$data = array("Title" => "Mr", "Email" => "sampleuser@test.com", "Password" => "password:01!", "ConfirmPassword" => "password:01!", "Forename" => "Joe", "Surname" => "Smith", "DOB" => "15/04/1982", "Sex" => "Male", "Country" => "United Arab Emirates", "SendRegistrationEmail" => "False", "ProviderKey" => $providerKey); 
$params = array("UserDetails" => $data);                                                                   
$data_string = json_encode($params);   
echo 'JSON: '.$data_string;                                                                                
$tmp_fname = tempnam("/temp", "COOKIE");

 
$ch = curl_init("https://app.medelinked/api/user/register");
curl_setopt($ch, CURLOPT_COOKIEJAR, $tmp_fname);
curl_setopt($ch, CURLOPT_SSL_VERIFYPEER, false);                                                                      
curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "POST");                                                                     
curl_setopt($ch, CURLOPT_POSTFIELDS, $data_string);                                                                  
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);                                                                      
curl_setopt($ch, CURLOPT_HTTPHEADER, array(                                                                          
    "Content-Type: application/json",                                                                                
    "Content-Length: " .strlen($data_string))                                                                       
);                                                                                                                   

$result = curl_exec($ch);
echo 'Curl error: ' . curl_error($ch);
echo '<br />Result: ' . $result;
$output = json_decode($result);
?>
		<h1>Medelinked API Tester</h1>
		<table>			
			<tr>
				<td>
					<strong>Patient Name:</strong>
				</td>
				<td colspan="2">
					<span id="status"><?php print($output->d->Name); ?></span>
				</td>
			</tr>
			
		</table>
	</body>
</html>