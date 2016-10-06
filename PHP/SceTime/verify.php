<?php
require 'init.php';
$email=$_POST["email"];
$password=$_POST["password"];

//$query = "select email, password, permission from Users where email=? and password=?";
$query = "select email, password, permission from Users where email=?";
$stmt = $conn->prepare($query);
if (!$stmt){
		echo "Error: verify-> prepare failed<br>".$conn->error;
		$conn->close();
		exit;
}
if (!$stmt->bind_param("s",$email)){
		echo "Error: verify-> bind param failed<br>".$stmt->error;
		$stmt->close();
		$conn->close();
		exit;
}
if (!$stmt->execute()){
				echo "Error: verify-> execute failed<br>".$stmt->error;
				$stmt->close();
				$conn->close();
				exit;
		}
if (!$stmt->store_result()){
				echo "Error: verify-> store failed<br>".$stmt->error;
				$stmt->close();
				$conn->close();
				exit;
		}
if (!$stmt->bind_result($res_email, $res_password, $res_permission)){
				echo "Error: verify-> bind result failed<br>".$stmt->error;
				$stmt->close();
				$conn->close();
				exit;
		}
if ($stmt->fetch() == false){
				echo "Error: verify-> fetch result failed<br>".$stmt->error;
				$stmt->close();
				$conn->close();
				exit;
}
$count = $stmt->num_rows;

if ($count == 0) {
		echo "declined";
}
else {
		$stmt->fetch();
		if (!strcmp($res_permission,"declined"))
			echo declined;
		else //admin or approved, check password
		{
		$hashedInput = (hash("md5",$password));
		if (!strcmp($hashedInput,$res_password))
			echo $res_permission;
		}
}
$stmt->free_result();
$conn->close();
?>