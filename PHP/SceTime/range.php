<?php
require 'init.php';
$key=$_POST["key"];
//$query="select distinct $key from Classes";
$query="select distinct ".getKey($key)." from Classes";

$stmt = $conn->prepare($query);
if (!$stmt){
		echo "Error: range -> prepare failed   ".$conn->error;
		$conn->close();
		exit;
}
if (!$stmt->execute()){
		echo "Error: range -> execute (both) failed<br>".$stmt->error;
		$stmt->close();
		$conn->close();
		exit;
}
if (!$stmt->store_result()){
		echo "Error: range -> store (both) failed<br>".$stmt->error;
		$stmt->close();
		$conn->close();
		exit;
}
if (!$stmt->bind_result($value)){
		echo "Error: range -> result (both) failed<br>".$stmt->error;
		$stmt->close();
		$conn->close();
		exit;
}

$count = $stmt->num_rows;
if ($count == 0) {
	echo "No rows found";
	$stmt->free_result();
	$stmt->close();
	$conn->close();
	exit;		
	}
$response = '';
for ($i=0; $i<$count;$i++){
		$stmt->fetch();
		$response = $response.$value;
		if ($i<$count-1)
				$response = $response.'*';
}
echo $response;
$stmt->free_result();
$stmt->close();
$conn->close();
?>