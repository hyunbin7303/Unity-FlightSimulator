using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestController : MonoBehaviour
{
    public float speed;
    private Rigidbody rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Yaw");
        float moveVertical = Input.GetAxis("Throttle");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rd.AddForce(movement * speed);
    }
}
