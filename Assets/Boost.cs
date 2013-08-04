using UnityEngine;
using System.Collections;

public class Boost : MonoBehaviour {
	
	public float acceleration, terminalVelocity;
	
	private float boostForceMagnitude;
	
	// Use this for initialization
	void Start () {
		boostForceMagnitude = rigidbody.mass*acceleration;
		rigidbody.drag = boostForceMagnitude/(terminalVelocity+10f*Time.fixedDeltaTime);
		ConstantForce f = gameObject.AddComponent<ConstantForce>();
		f.relativeForce = Vector3.forward*boostForceMagnitude;
		
	}
	
	void FixedUpdate(){	
	}
	
	void OnGUI() {
		GUI.Label( new Rect(0,0,200,20), "Speed: " + rigidbody.velocity.magnitude.ToString("N4") );
	}
	
}