<?php
	require 'init.php';
$id=$_POST["id"];

$id_array = explode(",", $id);
$id_count = count($id_array);
$query= "delete from Classes where ID=?";

$stmt = $conn->prepare($query);
if (!$stmt){
		echo "Error: deleteClass-> prepare failed<br>".$conn->error;
		$conn->close();
		exit;
}
for ($i=0; $i<$id_count; $i++){

		if (!$stmt->bind_param("i",$id_array[$i])){
				echo "Error: deleteClass-> bind param failed<br>".$stmt->error;
				$stmt->close();
				$conn->close();
				exit;
		}
		if (!$stmt->execute()){
						echo "Error: deleteClass-> execute failed<br>".$stmt->error;
						$stmt->close();
						$conn->close();
						exit;
				}
}

echo "deleted";
$conn->close();
?>