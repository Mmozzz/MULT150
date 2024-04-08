using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl2 : MonoBehaviour
{
    public float moveSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        


        if (mxVal != 0)
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (mxVal !=-0)
            transform.Translate(-Vector3.left * moveSpeed * Time.deltaTime);
        if (myVal !=0)
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        if (myVal !=-0)
            transform.Translate(-Vector3.up * moveSpeed * Time.deltaTime);
    }
}
