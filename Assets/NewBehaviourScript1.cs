using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public GameObject prefab001;
	void Update () 
	{
		if (Input.GetButtonDown ("Fire1")) 
		{
			Instantiate (prefab001);
		}
	}
}
