
using UnityEngine;
[RequireComponent(typeof(MoveCarXD))]
public class GameOver : MonoBehaviour
{
    public GameObject explode;
    public static bool lose = false;
    private bool Stop;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && !Stop)
        {
            lose = true;
            Stop = true;
            gameObject.GetComponent<MoveCarXD>().speed = 0f;
            other.gameObject.GetComponent<MoveCarXD>().speed = 0f;
            gameObject.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * -200);

            if (gameObject.transform.position.x < other.gameObject.transform.position.x)
            {
                Vector3 pos = Vector3.Lerp(gameObject.transform.position, other.transform.position, 0.5f);
                Instantiate(explode, new Vector3(pos.x, 0.7f, pos.z), Quaternion.identity);
            }
        }
    }
}
