using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowKeyRotate : MonoBehaviour
{
    private float Up = 0f;
    private float Down = 0f;
    private float Right = 0f;
    private float Left = 0f;

    void Start()
    {
        //var rotationVectorX = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            print("right arrow key was pressed");

            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z -= 5f;
            transform.rotation = Quaternion.Euler(rotationVector);
        }
        if (Input.GetKey("left"))
        {
            print("left arrow key was pressed");

            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z += 5f;
            transform.rotation = Quaternion.Euler(rotationVector);

        }
        /*
            * work in progress *
        if (Input.GetKey("up"))
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.x -= 1f;
            transform.rotation = Quaternion.Euler(rotationVector);
            print("up" + rotationVector);
        }
        if (Input.GetKey("down"))
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.x += 1f;
            transform.rotation = Quaternion.Euler(rotationVector);
            print("down" + rotationVector);
        }
        */

    }
}
/*
 
    if (Input.GetKey("up"))
    {
        print("up arrow key was pressed");
        IsKeyDown = true;

        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.z -= 5f;
        transform.rotation = Quaternion.Euler(rotationVector);
    }
    if (Input.GetKey("down"))
    {
        print("down arrow key was pressed");

        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.z += 5f;
        transform.rotation = Quaternion.Euler(rotationVector);

    }
    if (Input.GetKey("left"))
    {
        print("right arrow key was pressed");

        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.y += 5f;
        transform.rotation = Quaternion.Euler(rotationVector);
    }
    if (Input.GetKey("right"))
    {
        print("left arrow key was pressed");

        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.y -= 5f;
        transform.rotation = Quaternion.Euler(rotationVector);
    }

     
 */
