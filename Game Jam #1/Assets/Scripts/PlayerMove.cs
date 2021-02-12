using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody body;
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xforce = Input.GetAxis("Horizontal");
        float zforce = Input.GetAxis("Vertical");

        body.AddForce(new Vector3(xforce * speed, 0f, zforce * speed));
    }
}
