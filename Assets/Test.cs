using UnityEngine;
using System.Collections;
using DLLTest;

public class Test : MonoBehaviour {
	// Use this for initialization
	void Start () 
	{
		MyUtilities utils = new MyUtilities();
		utils.addValues(1000, 3000);
		print ("1000 + 3000 = " + utils.c);
	}
	
	// Update is called once per frame
	void Update () 
	{
		print (MyUtilities.GenerateRandom(0, 100));
	}

}