using UnityEngine.UI;
using UnityEngine;

public class Coins : MonoBehaviour
{
    void OnEnable(){
        GetComponent<Text>().text = PlayerPrefs.GetInt("Coins").ToString();
    }
}
