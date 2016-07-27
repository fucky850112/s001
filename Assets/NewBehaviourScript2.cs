using UnityEngine;
using System.Collections;

public class NewBehaviourScript2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float ver = Input.GetAxis ("Vertical");
		float hor = Input.GetAxis ("Horizontal");
		Vector2 vec = new Vector2 (ver, hor);
		if (vec.magnitude > 0) {
			transform.position = new Vector3 (transform.position.x + ver, transform.position.y + ver, transform.position.z + hor);
		}
	}
}
