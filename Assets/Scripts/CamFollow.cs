using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform Target;
    private Vector3 Offset;
    public float smooth_speed = 0.04f;
    void Start()
    {
        Offset = transform.position - Target.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = Vector3.Lerp(transform.position, Target.position + Offset, smooth_speed);
        transform.position = newPosition;
    }
}
