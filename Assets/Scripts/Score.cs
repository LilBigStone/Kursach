using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{   [SerializeField]
    private Text topRecord;
    void OnEnable()
    {
        GetComponent<Text>().text = " <color=#FE9377>Score:</color> " + DeleteCars.countCars.ToString();
        if (PlayerPrefs.GetInt("Score") < DeleteCars.countCars)
        {
            PlayerPrefs.SetInt("Score", DeleteCars.countCars);
            topRecord.text = "<color=#FE9377>Top:</color> " + DeleteCars.countCars.ToString();
        }
        else
        {
            topRecord.text = "<color=#FE9377>Top:</color> " + PlayerPrefs.GetInt("Score").ToString();
        }
    }
}
