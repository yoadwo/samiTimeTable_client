<?php
$servername = "mysql.hostinger.co.il";
$username = "u812323954_yoyo";
$password = "yoadgaz1";
$database = "u812323954_sami";

function getKey( $get_var ) 
{
    switch($get_var)
    {
        case "courseName":
            $key = "courseName";
            break;
				case "day":
						$key = "day";
						break;
				case "teacherName":
						$key = "teacherName";
						break;
    }
		return $key;
}

// Create connection
$conn = new mysqli($servername, $username, $password, $database);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
?>