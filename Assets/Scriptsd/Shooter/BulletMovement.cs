using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float force;
    private Transform tf;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();

        rb.AddForce(tf.right * force);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,0,1)*force*Time.deltaTime);
    }
}
