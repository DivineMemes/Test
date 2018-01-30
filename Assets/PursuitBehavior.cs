using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PursuitBehavior : MonoBehaviour
{

    Rigidbody rb;
    Rigidbody targetRb;
    Vector3 desiredVelocity;
    Vector3 projectedPosition;
    public float acceptableDistance;
    public float speed;
    public Transform target;
    float dist;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        targetRb = target.GetComponent<Rigidbody>();
    }


    void Update()
    {

        dist = Vector3.Distance(transform.position, target.position);
        if(dist > acceptableDistance)
        {
            projectedPosition = target.position + targetRb.velocity;
            desiredVelocity = speed * (projectedPosition - transform.position).normalized;
            rb.AddForce(desiredVelocity - rb.velocity);
        }
        else
        {
            desiredVelocity = speed * (target.position - transform.position).normalized;
            rb.AddForce(desiredVelocity - rb.velocity);
        }
    }
}
