using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class MoveCarXD : MonoBehaviour
{  
    private Rigidbody rb;
    public float speed = 0.3f;
    Vector3 startPosition;
   // static public GameObject CarD;
   
    void Start()
    {
      
      // rb = CarD.GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
        rb.transform.localPosition = new Vector3(rb.transform.localPosition.x, 0.074f, rb.transform.localPosition.z);

    }
    void FixedUpdate()
    {
        //rb.transform.localPosition = new Vector3(CarD.transform.localPosition.x, 0.074f, CarD.transform.localPosition.z);
        rb.transform.localPosition = new Vector3(rb.transform.localPosition.x, rb.transform.localPosition.y, rb.transform.localPosition.z);

        rb.transform.Translate(Vector3.back* speed * Time.fixedDeltaTime, Space.Self);
      
    }
    
}
