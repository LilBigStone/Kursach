using System.Collections;
using UnityEngine;
[RequireComponent(typeof(MoveCarXD))]
[RequireComponent(typeof(TurnLights))]

public class UpTurnRight : MonoBehaviour
{
    private Rigidbody rb;
    private float angleT;


    void Start()
    {

        rb = GetComponent<Rigidbody>();
        GetComponent<TurnLights>().showObject = 0;
    }

    void FixedUpdate()
    {
        RightTurn();
    }

    void RightTurn()
    {
        float carRotation = Mathf.Floor(transform.localEulerAngles.y);
        Debug.Log(carRotation);

        if (transform.localPosition.x > 0.250f && carRotation != 0f)
        {

            if (carRotation >= -4f && carRotation <= 6f)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(0, 0f, 0));
                return;
            }
            angleT = GetComponent<MoveCarXD>().speed * 600.0057f;
            Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, angleT, 0) * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

        }
    }
}
