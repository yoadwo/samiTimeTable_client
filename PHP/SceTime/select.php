<?php
require 'init.php';

$key=$_POST["key"];
$value=$_POST["value"];
$type=$_POST["type"];

if (!strcmp($type, "both") ){
		$query = "select * from Classes where ".getKey($key) ."=?";
		$stmt = $conn->prepare($query);
		if (!$stmt){
				echo "Error: select -> prepare (both) failed   ".$conn->error;
				$conn->close();
				exit;
		}
		if (!$stmt->bind_param("s", $value)){
				echo "Error: select -> bind (both) failed<br>".$stmt->error;
				$stmt->close();
				$conn->close();
				exit;
		}
		if (!$stmt->execute()){
				echo "Error: select -> execute (both) failed<br>".$stmt->error;
				$stmt->close();
				$conn->close();
				exit;
		}
		if (!$stmt->store_result()){
				echo "Error: select -> store (both) failed<br>".$stmt->error;
				$stmt->close();
				$conn->close();
				exit;
		}
		if (!$stmt->bind_result($id, $course, $teacher, $room, $day, $start, $end, $type)){
				echo "Error: select -> result (both) failed<br>".$stmt->error;
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
				$response = $response.$id."*".$course."*".$teacher."*".$room."*".$day."*".$start."*".$end."*".$type;    
				if ($i<$count-1)
						$response = $response.'#';
		}
		echo "OK@".$response;
		$stmt->free_result();
		$stmt->close();
}
else if (!strcmp($type, "All") ){
		$query = "select * from Classes";
		$stmt = $conn->prepare($query);
		if (!$stmt){
				echo "Error: select -> prepare (All) failed   ".$conn->error;
				$conn->close();
				exit;
		}
		if (!$stmt->execute()){
				echo "Error: select -> execute (All) failed<br>".$stmt->error;
				$stmt->close();
				$conn->close();
				exit;
		}
		if (!$stmt->store_result()){
				echo "Error: select -> store (All) failed<br>".$stmt->error;
				$stmt->close();
				$conn->close();
				exit;
		}
		if (!$stmt->bind_result($id, $course, $teacher, $room, $day, $start, $end, $type)){
				echo "Error: select -> result (All) failed<br>".$stmt->error;
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
				$response = $response.$id."*".$course."*".$teacher."*".$room."*".$day."*".$start."*".$end."*".$type;    
				if ($i<$count-1)
						$response = $response.'#';
		}
		echo "OK@".$response;
		$stmt->free_result();
		$stmt->close();
}
else {

		$query = "select * from Classes where ".getKey($key) ."=? and type =?";
		$stmt = $conn->prepare($query);
		if (!$stmt){
				echo "Error: select-> prepare ($type) failed<br>".$conn->error;
				$conn->close();
				exit;
		}
		if (!$stmt->bind_param("ss", $value,$type)){
				echo "Error: select-> bind ($type) failed<br>".$stmt->error;
				$stmt->close();
				$conn->close();
				exit;
		}
		if (!$stmt->execute()){
				echo "Error: select-> execute ($type) failed<br>".$stmt->error;
				$stmt->close();
				$conn->close();
				exit;
		}
		if (!$stmt->store_result()){
				echo "Error: select-> store ($type) failed<br>".$stmt->error;
				$stmt->close();
				$conn->close();
				exit;
		}
		if (!$stmt->bind_result($id, $course, $teacher, $room, $day, $start, $end, $type)){
				echo "Error: select-> bind result ($type) failed<br>".$stmt->error;
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
				$response = $response.$id."*".$course."*".$teacher."*".$room."*".$day."*".$start."*".$end."*".$type;    
				if ($i<$count-1)
						$response = $response.'#';
		}
		echo "OK@".$response;
		$stmt->free_result();
		$stmt->close();
}

$conn->close();
?>