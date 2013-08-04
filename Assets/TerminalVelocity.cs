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

using UnityEngine;
using System.Collections;


public class TerminalVelocity : MonoBehaviour {
	
	public float dragCoefficient = 0.82f;
	public float objectDensity = 1.0f;
	public float fluidDensity = 1000.0f;

	private Transform thisTransform;
	private float boostForceMagnitude;
	private float termVel;
	
	// Use this for initialization
	void Start () {
		Vector3 gravityVec = UnityEngine.Physics.gravity;
		thisTransform = transform;
		float densityVal = Mathf.Abs((objectDensity - fluidDensity) / fluidDensity);
		float dragCalc = (4.0f * Mathf.Abs(gravityVec.y) * rigidbody.mass) / (3.0f * dragCoefficient);
		termVel = Mathf.Sqrt(dragCalc * densityVal);
		boostForceMagnitude = rigidbody.mass*gravityVec.y;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	// Calculates and updates Physics
	void FixedUpdate() {
		rigidbody.drag = Mathf.Abs(boostForceMagnitude/(termVel+10f*Time.fixedDeltaTime));
		Debug.Log(string.Format("[TerminalVelocity.cs] Drag={0} BoostForceMagnitude={1:0.0}", rigidbody.drag, boostForceMagnitude));
		Debug.Log(string.Format("[TerminalVelocity.cs] ActualVelocity={0} TerminalVelocity={1:0.0}", rigidbody.velocity.magnitude, termVel));
	}
}
