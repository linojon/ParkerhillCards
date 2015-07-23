using UnityEngine;
using System.Collections;

public class FixedHeight : MonoBehaviour {
	public float startY;
	public Vector3 ccc;

	void Start () {
		startY = Camera.main.transform.position.y;
		//ccc = Camera.main.transform.position;
	}
	
	void Update () {
		Vector3 camera = new Vector3(Camera.main.transform.position.x, startY, Camera.main.transform.position.z);
		Camera.main.transform.position = camera;
//		Camera.main.transform.position = ccc;
	}
}
