using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float RotationSpeed;


    void Update()
    {
       /* if (!GameManager.isGameStarted)
            return;*/

        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X");
            transform.Rotate(new Vector3(0, RotationSpeed * -mouseX * Time.deltaTime, 0));
        }

     /* if(Input .touchCount > 0 && Input .GetTouch(0).phase == TouchPhase.Moved)
        {
            float xTouch = Input.GetTouch(0).deltaPosition.x;
            transform.Rotate(0, RotationSpeed * -xTouch * Time.deltaTime, 0);
        }*/
    }
}
