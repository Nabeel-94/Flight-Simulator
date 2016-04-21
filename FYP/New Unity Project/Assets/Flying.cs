using UnityEngine;
using System.Collections;

public class Flying : MonoBehaviour {
    float rotateSpeed = 25.0f;
    float speed= 50.0f;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        float transAmount = speed * Time.deltaTime;
        float rotateAmount = rotateSpeed * Time.deltaTime;
        if (Input.GetKey("down"))
        {
            transform.Rotate(rotateAmount, 0, 0);

        }
        if (Input.GetKey("up"))
        {
            transform.Rotate(-rotateAmount, 0, 0);
        }
        if (Input.GetKey("z"))
        {
            transform.Rotate(0, -rotateAmount, 0);
        }
        if (Input.GetKey("x"))
        {
            transform.Rotate(0, rotateAmount, 0);
        }

        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 0, rotateAmount);
        }

        if (Input.GetKey("left"))
        {
            transform.Rotate(0, 0, -rotateAmount);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(0, 0, -transAmount);
        }

        if (Input.GetKey("q"))
        {

            transform.Translate(0, 0, -(transAmount * 2));
        }


    }
}




