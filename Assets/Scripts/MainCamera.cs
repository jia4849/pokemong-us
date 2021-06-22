using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{

    public Transform target;
    public float smoothFactor = 0.3f;
    public Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = target.transform.position - transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        // Calculate new position of camera
        Vector3 newPos = target.transform.position - cameraOffset;
        transform.position = Vector3.Lerp(transform.position, newPos, smoothFactor);
        transform.position = newPos;

    }

}