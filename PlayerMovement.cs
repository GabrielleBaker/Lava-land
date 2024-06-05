using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 5.0f;
    private float horizontalInput;
    private float verticalInput;
    private Vector3 movedirection;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        movedirection = new Vector3(horizontalInput , 0, verticalInput);
        movedirection.Normalize();
        transform.position += movedirection * speed * Time.deltaTime;

    }
    
}
