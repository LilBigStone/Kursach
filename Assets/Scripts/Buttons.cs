using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public Sprite button, pressed;
    public bool music;
    private Image img;
    private float yPos;
    private Transform child;
    void Start()
    {
        img = GetComponent<Image>();
        child = transform.GetChild(0).transform;
        if (music)
        {
            if (PlayerPrefs.GetString("Music") != "no")
            {
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(1).gameObject.SetActive(false);
            }
            else
            {
               
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(1).gameObject.SetActive(true);
                child = transform.GetChild(1).transform;
            }
        }
        
    }
    void OnMouseDown()
    {
       
        yPos = child.localPosition.y;
        child.localPosition = new Vector3(child.localPosition.x, 0, child.localPosition.z);
        img.sprite = pressed;
    }
    void OnMouseUp()
    {
        child.localPosition = new Vector3(child.localPosition.x, yPos, child.localPosition.z);
        img.sprite = button;
    }

    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "Play":
                StartCoroutine(LoadScene("game"));
                break;
            case "Replay":
                StartCoroutine(LoadScene("game"));
                break;
            case "Home":
                StartCoroutine(LoadScene("main"));
                break;
            case "Shop":
                StartCoroutine(LoadScene("shop"));
                break;
            case "Close":
                StartCoroutine(LoadScene("main"));
                break;
            case "Music":
                child.gameObject.SetActive(false);
                if (PlayerPrefs.GetString("Music") != "no")
                {
                    
                    PlayerPrefs.SetString("Music", "no");
                    child = transform.GetChild(1).transform;
                }
                else
                {
                    PlayerPrefs.DeleteKey("Music");
                    child = transform.GetChild(0).transform;
                }
                child.gameObject.SetActive(true);
                break;
        }
    }
    IEnumerator LoadScene(string scene)
    {
       
       // float fadeTime = Camera.main.GetComponent<Fading>().BeginFade(1);
        //yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(scene);
        yield return null;
    }
}
