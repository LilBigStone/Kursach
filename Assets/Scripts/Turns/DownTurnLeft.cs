using System.Collections;
using UnityEngine;
[RequireComponent(typeof(TurnLights))]
[RequireComponent(typeof(MoveCarXD))]
public class DownTurnLeft : MonoBehaviour
{
    private Rigidbody rb;
    private float angleT;


    void Start()
    {
       
    
        rb = GetComponent<Rigidbody>();
        GetComponent<TurnLights>().showObject = 1;
    }

    void FixedUpdate()
    {
        LeftTurn();
    }

    void LeftTurn()
    {
        float carRotation = Mathf.Floor(transform.localEulerAngles.y);
        Debug.Log(carRotation);

        if (transform.localPosition.x < 0.365f && carRotation != 0f)
        {

            if (carRotation >= -1f && carRotation <= 6f)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
                return;
            }
            angleT = GetComponent<MoveCarXD>().speed * -600.0057f;
            Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, angleT, 0) * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

        }
    }
}
