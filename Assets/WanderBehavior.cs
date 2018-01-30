using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderBehavior : MonoBehaviour
{
    public float speed;
    public float radius;
    public float jitter;
    public float distance;
    public Vector3 target;
    Rigidbody rb;
    
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	
	void Update ()
    {
        target = Vector3.zero;
        target = Random.insideUnitCircle.normalized * radius;
        target = (Vector2)target + Random.insideUnitCircle * jitter;
        target.z = target.y;
        target.y = 0;
        target += transform.position;
        target += transform.forward * distance;
        Vector3 dir = (target - transform.position).normalized;
        Vector3 desiredVel = dir * speed;
        //rb.AddForce();
	}
}
