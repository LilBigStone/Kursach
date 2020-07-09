using UnityEngine;

public class ShowLose : MonoBehaviour
{
    [SerializeField]
    private GameObject losePanel;
    private bool addOnce;

    void Update()
    {
        if (GameOver.lose && !addOnce)
        {
            addOnce = true;
            losePanel.SetActive(true);
        }
        
    }
}
