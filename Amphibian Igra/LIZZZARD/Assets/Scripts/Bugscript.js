#pragma strict
public var speed : int = -5;
function Start () {
GetComponent.<Rigidbody2D>().velocity.y =speed;
GetComponent.<Rigidbody2D>().angularVelocity=Random.Range(-200,200);
Destroy(gameObject,3);
}

function Update () {

}
function OnTriggerEnter2D(obj : Collider2D) {  
    var name = obj.gameObject.name;

    if (name == "BUG(Clone)") {
      
        Destroy(gameObject);

     
        Destroy(obj.gameObject);
    }

    if (name == "lizard2") {

        Destroy(gameObject);
    }
}