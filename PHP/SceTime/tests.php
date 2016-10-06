<?php
require 'init.php';
//working oop-php

header('Content-type: application/octet-stream');
//open/save dialog box
header('Content-Disposition: attachment; filename="samiTimeTable.exe"');
//read from server and write to buffer
readfile('samiTimeTable.exe');
?>