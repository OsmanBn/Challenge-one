using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 25f;
    private float horizontallInput = 25f;
    private float forwardInput = 25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //we move the vehicle forward
        horizontallInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //we move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //we turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontallInput);
        
    }
}
