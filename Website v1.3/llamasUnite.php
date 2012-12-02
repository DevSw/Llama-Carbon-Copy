<?php 
$programID = $_REQUEST['os0'];

function GetLicense($productID, $days) {
	$w1 = substr($productID, 0, 5);
	$w2 = substr($productID, 5, 5);
	$pounds = 	mt_rand(10000, 49999);
	$esses = $w2 - $w1 - $days + $pounds;
	$dubs = CalculateFx($w1, $w2);
	$exes = CalculateFx($esses.'', $w1);
	$tees = CalculateFx($pounds.'', $w2);
	return "$pounds-$exes-$dubs-$tees-$esses";
}
function CalculateFx($s1, $s2){
	$toReturn = '';
	for($i = 0; $i < 5; $i++) { 
		$toReturn = $toReturn . abs( $s1[$i] - $s2[$i] ); 				
	}
	return $toReturn;
}


if( ! is_numeric($programID) ) {
	echo '00000-00000-00000-00000-00000';
} else {
	$days = 31;//mt_rand(31, 101);
	echo GetLicense($programID, $days);
}

?>
