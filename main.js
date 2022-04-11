function showAlert()
 {
    alert("Alert from JS file");
}

function updateHeading() {
    document.getElementById('heading').innerHTML = 'Kiša pada';
}

function list (){

document.getElementById("demo").innerHTML = fruits.toString();
}

function sort () 
{
	fruits.sort();
	document.getElementById("demo2").innerHTML = fruits;
}