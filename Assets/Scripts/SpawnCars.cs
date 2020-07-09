using System.Collections;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    public GameObject[] cars;

    private float startSpawn = 0.5f, waitSpawn=7f;
    public GameObject CarT;
    private int countCars = 0;
    private bool Stop;
    

    void Start()
    {
        
        StartCoroutine(UpCars());
        StartCoroutine(DownCars());
        StartCoroutine(LeftCars());
        StartCoroutine(RightCars());
        GameOver.lose = false;
    }
    void Update()
    {
        if (countCars > 60)
        {
            waitSpawn = 4f;
        }
        if (countCars > 40)
        {
            waitSpawn = 5f;
        }
        if (countCars > 20)
        {
            waitSpawn = 6f;
        }
        if (GameOver.lose&&!Stop)
        {
            StopAllCoroutines();
            Stop = true;
        }
    }

    IEnumerator UpCars()
    {Vector3 thePosition;
        thePosition = new Vector3(-0.655f, 0.074f, -0.218f); 
        yield return new WaitForSeconds(Random.Range(startSpawn, startSpawn + 4.5f));
        while (true)
        {
            GameObject carInst = Instantiate(cars[Random.Range(0, cars.Length)], CarT.transform.TransformPoint(thePosition), Quaternion.Euler(new Vector3(0,CarT.transform.localEulerAngles.y+270f,0)), CarT.transform) as GameObject;
            countCars++;
            int randTurn = Random.Range(0, 4);
            switch (randTurn)//new Vector3(-0.655f, 0.074f, -0.218f)
            {
                case 1:
                    carInst.AddComponent<UpTurnLeft>();

                    break;
                case 2:
                    carInst.AddComponent<UpTurnRight>();
                    break;
            }
            yield return new WaitForSeconds(Random.Range(waitSpawn, waitSpawn + 5f));
        }
    }
    IEnumerator DownCars()
    {
        Vector3 thePosition;
        thePosition = new Vector3(0.705f, 0.074f, -0.145f);
        yield return new WaitForSeconds(Random.Range(startSpawn, startSpawn + 4.5f));
        while (true)
        {
            GameObject carInst = Instantiate(cars[Random.Range(0, cars.Length)], CarT.transform.TransformPoint(thePosition), Quaternion.Euler(new Vector3(0, CarT.transform.localEulerAngles.y + 90f, 0)), CarT.transform) as GameObject;
            countCars++;
            int randTurn = Random.Range(0, 4);
            switch (randTurn)
            {
                case 1:
                    carInst.AddComponent<DownTurnLeft>();

                    break;
                case 2:
                    carInst.AddComponent<DownTurnRight>();
                    break;
            }
            yield return new WaitForSeconds(Random.Range(waitSpawn, waitSpawn + 5f));
        }
    }
    IEnumerator LeftCars()
    {
        Vector3 thePosition;
        thePosition = new Vector3(0.401f, 0.074f, -0.584f);
        yield return new WaitForSeconds(Random.Range(startSpawn, startSpawn + 4.5f));
        while (true)
        {
            GameObject carInst = Instantiate(cars[Random.Range(0, cars.Length)], CarT.transform.TransformPoint(thePosition), Quaternion.Euler(new Vector3(0, CarT.transform.localEulerAngles.y + 180f, 0)), CarT.transform) as GameObject;
            countCars++;
            int randTurn = Random.Range(0, 4);
            switch (randTurn)
            {
                case 1:
                    carInst.AddComponent<LeftTurnDown>();

                    break;
                case 2:
                    carInst.AddComponent<LeftTurnUp>();
                    break;
            }
            yield return new WaitForSeconds(Random.Range(waitSpawn, waitSpawn + 5f));
        }
    }
    IEnumerator RightCars()
    {
        Vector3 thePosition;
        thePosition = new Vector3(0.313f, 0.074f, 0.564f);
        yield return new WaitForSeconds(Random.Range(startSpawn, startSpawn + 4.5f));
        while (true)
        {
            GameObject carInst = Instantiate(cars[Random.Range(0, cars.Length)], CarT.transform.TransformPoint(thePosition), Quaternion.Euler(new Vector3(0, CarT.transform.localEulerAngles.y, 0)), CarT.transform) as GameObject;
            countCars++;
            int randTurn = Random.Range(0, 4);
            switch (randTurn)
            {
                case 1:
                    carInst.AddComponent<RightTurnDown>();

                    break;
                case 2:
                    carInst.AddComponent<RightTurnUp>();
                    break;
            }
            yield return new WaitForSeconds(Random.Range(waitSpawn, waitSpawn + 5f));
        }
    }
}
