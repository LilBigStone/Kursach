using UnityEngine;
[RequireComponent(typeof(MoveCarXD))]
public class Speed : MonoBehaviour
{
    public GameObject exhaust;
    private bool accelerate = false;
    void OnMouseDown()
    {
        if (!accelerate)
        {
            GetComponent<MoveCarXD>().speed *= 2f;
            accelerate = true;

            GameObject ex = Instantiate(exhaust,
                new Vector3(gameObject.transform.position.x, 0.4f, gameObject.transform.position.z),
                Quaternion.Euler(new Vector3(90, 0, 0))) as GameObject;
            Destroy(ex, 1f);
        }
    }
}
