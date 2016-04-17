using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
    

	public float minX = -45.0f;
	public float maxX = 45.0f;
	
	public float minY = -45.0f;
	public float maxY = 45.0f;

	public float sensX = 15.0f;
	public float sensY = 15.0f;
	
	float rotationY = 0.0f;
	float rotationX = 180.0f;

	void Update () {

		//if (Input.GetMouseButton (0)) {
			rotationX += Input.GetAxis ("Mouse X") * sensX * Time.deltaTime;
        //  rotationX = Mathf.Clamp(rotationX, minX  , maxX);
          rotationY += Input.GetAxis ("Mouse Y") * sensY * Time.deltaTime;
			rotationY = Mathf.Clamp (rotationY, minY, maxY);
			transform.localEulerAngles = new Vector3 (-rotationY, rotationX, 0);
		//}
	}
}
