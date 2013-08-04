#pragma strict

/*
 This force will, when applied to an object, attempt to simulate
 the Terminal Velocity of an object falling through a fluid. The
 equation to calculate the same is as follows:
 		Vt = sqrt(((4*g*d)/3Cd) * ((Ps - P)/P))
 		
 where
 	Vt = Terminal Velocity
 	g  = Accelaration due to gravity
 	d  = Mass of the object falling in the fluid
 	Cd = Drag co-efficient
 	Ps = Density of the object
 	P  = Density of the fluid
*/

public var mass : float;
public var dragCoefficient : float;
public var objectDensity : float;
public var fluidDensity : float;

private var thisTransform : Transform;

/*
private var rotateAround : Vector3;
private var minQuaternion : Quaternion;
private var maxQuaternion : Quaternion;
private var range : float;
*/


function Start () {
	var gravityVec : Vector3;
	gravityVec = Physics.gravity;
	print(gravityVec.y.ToString());
}

function Update () {
	thisTransform = transform;
	var rb : Rigidbody;
	rb = thisTransform.GetComponent(Rigidbody);
	print(rb.velocity.magnitude.ToString());
}