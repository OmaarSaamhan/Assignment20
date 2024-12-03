using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

    public Vector3 max = new Vector3(4.5f, 0.5f, 4.5f);

    float xPos = 4.5f;
    float zPos = 4.5f;

    public float speed = 10;

    void Update()
    {
        xPos -= Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        zPos -= Input.GetAxis("Vertical") * Time.deltaTime * speed;


        xPos = Mathf.Clamp(xPos, -max.x, max.x);
        zPos = Mathf.Clamp(zPos, -max.x, max.z);

        transform.position = new Vector3(xPos, 0, zPos);
    }
}
