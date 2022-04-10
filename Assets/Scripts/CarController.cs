using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float acceleration;
    public float maxSpeed;
    public float turnSpeed;
    private float curSpeed;

    public bool doAccelerate;
    private Rigidbody rb;

    public static CarController instance;
    private void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
        if (doAccelerate)
        {
            curSpeed = Mathf.Clamp(curSpeed + (acceleration * Time.deltaTime), 0, maxSpeed);
        }
        else
        {
            curSpeed = Mathf.Clamp(curSpeed - (acceleration * Time.deltaTime), 0, maxSpeed);
        }

        rb.velocity = transform.forward * curSpeed;
    }

    public void Turn(float rate)
    {
        transform.Rotate(Vector3.up, rate * turnSpeed * Time.deltaTime);
    }
}
