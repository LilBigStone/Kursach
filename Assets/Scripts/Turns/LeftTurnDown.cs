using System.Collections;
using UnityEngine;
[RequireComponent(typeof(TurnLights))]
[RequireComponent(typeof(MoveCarXD))]
public class LeftTurnDown : MonoBehaviour
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

        if (transform.localPosition.z > -0.292 && carRotation != 270f)
        {

            if (carRotation >= 266f && carRotation <= 286f)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(0f, 270f, 0f));
                return;
            }
            angleT = GetComponent<MoveCarXD>().speed * 600.0057f;
            Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, angleT, 0) * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

        }
    }
}
