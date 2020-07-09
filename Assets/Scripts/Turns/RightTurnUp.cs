using System.Collections;
using UnityEngine;
[RequireComponent(typeof(TurnLights))]
[RequireComponent(typeof(MoveCarXD))]
public class RightTurnUp : MonoBehaviour
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

        if (transform.localPosition.z < -0.1 && carRotation != 90f)
        {

            if (carRotation >= 85f && carRotation <= 95f)
            {
                transform.localRotation = Quaternion.Euler(new Vector3(0f, 90f, 0f));
                return;
            }
            angleT = GetComponent<MoveCarXD>().speed * 600.0057f;
            Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, angleT, 0) * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

        }
    }
}
