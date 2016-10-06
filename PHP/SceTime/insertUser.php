<?php
require 'init.php';

$email=$_POST["email"];
$studentName=$_POST["studentName"];
$password=$_POST["password"];

//$query = "select * from Users where studentName =? and email=?";
$query = "select studentName, email from Users where studentName =? and email=?";
$stmt = $conn->prepare($query);
if (!$stmt){
		echo "Error: prepare select failed<br>".$conn->error;
		$conn->close();
		exit;
}
if (!$stmt->bind_param("ss", $studentName,$email)){
		echo "Error: bind param select failed<br>".$stmt->error;
		$stmt->close();
		$conn->close();
		exit;
}
if (!$stmt->execute()){
		echo "Error: execute select failed<br>".$stmt->error;
		$stmt->close();
		$conn->close();
		exit;
}
if (!$stmt->store_result()){
		echo "Error: store select failed<br>".$stmt->error;
		$stmt->close();
		$conn->close();
		exit;
}
//if (!$stmt->bind_result($id, $name, $email, $permission, $password)){
if (!$stmt->bind_result($name, $email)){
		echo "Error: bind result select failed<br>".$stmt->error;
		$stmt->close();
		$conn->close();
		exit;
}

$count = $stmt->num_rows;
if ($count == 0){ //insert
		$query = "insert into Users (email, studentName, permission, password)
						value (?, ?, 'declined', ?)";
		$stmt = $conn->prepare($query);
		if (!$stmt){
						echo "Error: prepare insert failed<br>".$conn->error;
						$conn->close();
						exit;
				}
		$hashed = hash("md5",$password);		
//		if (!$stmt->bind_param("sss",$email,$studentName, $password)){
		if (!$stmt->bind_param("sss",$email,$studentName, $hashed)){
						echo "Error: bind param insert failed<br>".$stmt->error;
						$stmt->close();
						$conn->close();
						exit;
				}
		if (!$stmt->execute()){
						echo "Error: execute insert failed<br>".$stmt->error;
						$stmt->close();
						$conn->close();
						exit;
				}
		echo "inserted";
}
else //exists
		echo "exists";
$stmt->free_result();

$conn->close();
?>