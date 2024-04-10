using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //// Rotate the object around its local X axis at 1 degree per second
        //transform.Rotate(Vector3.right * 5);
        //transform.Rotate(Vector3.up * 5);
        //transform.RotateAround(t, Vector3 axis, float angle);

        // Rotate the object around its local X axis at 1 degree per second
        //transform.Rotate(Vector3.right * Time.deltaTime);

        // ...also rotate around the World's Y axis
        //transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
    }
}
