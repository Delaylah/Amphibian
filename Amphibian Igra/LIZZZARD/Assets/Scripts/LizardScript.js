#pragma strict
public var jezik : GameObject;

function Start () {

}

function Update () {
GetComponent.<Rigidbody2D>().velocity.x =
Input.GetAxis("Horizontal")*10;
GetComponent.<Rigidbody2D>().velocity.y =
Input.GetAxis("Vertical")*10;
if(Input.GetKeyDown("space")){
Instantiate(jezik,transform.position,
Quaternion.identity);
}

}