using UnityEngine;
using System.Collections;

public class scrHiding : MonoBehaviour {

	//static bool hiding;
	//static float Xposition;
	//static float Yposition;
	//static float Zposition;
	private MeshRenderer meshRend;

	// Use this for initialization
	void Start () {
		meshRend = GetComponent <MeshRenderer> ();
	}

	// Update is called once per frame
	void Update () {
		
		//transform.position.x = scrMovement.Xposition;

		if (Input.GetKey (KeyCode.Space)) {
			meshRend.enabled = false;
			//transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
		} else {
			meshRend.enabled = true;
		}
	}
}
