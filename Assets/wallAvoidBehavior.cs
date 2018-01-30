using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallAvoidBehavior : MonoBehaviour
{
    Rigidbody rb;
    public float avoidanceStr;
    public float avoidanceRange;
    

    void Start ()
    {
        
        rb = GetComponent<Rigidbody>();
	}
	
	
    public void doWallAvoid()
    {
        RaycastHit hit;
        Vector3 wallDir = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        if (Physics.Raycast(transform.position, wallDir, out hit, avoidanceRange))
        {
            rb.AddForce(hit.normal * avoidanceStr);
        }
    }

	void Update ()
    {
        doWallAvoid();
	}
}
