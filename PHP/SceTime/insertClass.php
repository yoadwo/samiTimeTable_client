<?php
require 'init.php';

$type=$_POST["type"];
$course=$_POST["course"];
$teacher=$_POST["teacher"];
$room=$_POST["room"];
$day=$_POST["day"];
$start=$_POST["start"];
$end=$_POST["end"];
$id=$_POST["id"];

if ($id == -1){ //insertion
		$query = "INSERT INTO Classes (courseName, teacherName,roomNum,day,startTime, endTime, type)
				SELECT ?,?,?,?,?,?,? FROM Classes
				WHERE NOT EXISTS
				(SELECT courseName, teacherName,roomNum,day,startTime, endTime, type
				FROM Classes
				WHERE courseName=? and teacherName=? and roomNum=?
				and day=? and startTime=? and endTime=? and type=? ) 
				LIMIT 1";
		$stmt = $conn->prepare($query);
		if (!$stmt){
				echo "Error: prepare failed";
				$conn->close();
				exit;
	}
		if (!$stmt->bind_param("ssssssssssssss",$course,$teacher,$room,$day,$start,$end,$type,
						$course,$teacher,$room,$day,$start,$end,$type)){
			echo "Error: bind failed";
			$stmt->close();
			$conn->close();
			exit;
		}
		if (!$stmt->execute()){
				echo "Error: execute failed";
				$stmt->close();
				$conn->close();
				exit;
	}
	echo "Inserted";
	$stmt->close();
}

else { //update
		$query = "update Classes set
				courseName=?, teacherName=?, roomNum=?,
				day=?, startTime=?, endTime=?, type=?
				where id=?";
		
		$stmt = $conn->prepare($query);
		if (!stmt){
				echo "Error: prepare failed";
				$conn->close();
				exit;
		}
		if (!$stmt->bind_param("sssssssi", $course,$teacher,$room,$day,$start,$end,$type,$id)){
				echo "Error: bind failed";
				$stmt->close();
				$conn->close();
				exit;
		}
		if (!$stmt->execute()){
				echo "Error: execute failed";
				$stmt->close();
				$conn->close();
				exit;
		}
		echo "Updated";
		$stmt->close();
}
$conn->close();
?>