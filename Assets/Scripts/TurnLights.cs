using System.Collections;
using UnityEngine;

public class TurnLights : MonoBehaviour
{
    public int showObject;
    void Start()
    {
        StartCoroutine(Light());
       
    }
    IEnumerator Light()
    {
        yield return new WaitForSeconds(0.2f);
        GameObject light = gameObject.transform.GetChild(showObject).gameObject;
        while (true)
        {
            light.SetActive(!light.activeSelf);
            yield return new WaitForSeconds(0.5f);
        }

    }
}
