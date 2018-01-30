using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeBehaviour : MonoBehaviour
{

    Rigidbody rb;
    Vector3 desiredVelocity;

    public float speed;
    public Transform target;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        desiredVelocity = -speed * (target.position - transform.position).normalized;
        rb.AddForce(desiredVelocity - rb.velocity);
    }
}
