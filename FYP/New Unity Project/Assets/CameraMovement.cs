﻿using UnityEngine;
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
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
           
            GameObject Camera2 = GameObject.Find("Empty");
            GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
            camera.transform.position = Camera2.transform.position;
        }
        if (Input.GetMouseButton(2))
        {

            GameObject Camera2 = GameObject.Find("Empty2");
            GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
            camera.transform.position = Camera2.transform.position;
        }


        if (Input.GetMouseButton(0))
        {

            rotationX += Input.GetAxis("Mouse X") * sensX * Time.deltaTime;
            rotationX = Mathf.Clamp(rotationX, minX, maxX);
            rotationY += Input.GetAxis("Mouse Y") * sensY * Time.deltaTime;
            rotationY = Mathf.Clamp(rotationY, minY, maxY);
            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
            rotationY += Input.GetAxis("Vertical") * sensY * Time.deltaTime;
            rotationY = Mathf.Clamp(rotationY, minY, maxY);
            rotationX += Input.GetAxis("Horizontal") * sensX * Time.deltaTime;
            rotationX = Mathf.Clamp(rotationX, minX, maxX);

        }
    }
}
