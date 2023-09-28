using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AdClose : MonoBehaviour
{
    public GameObject closeButton;
    public GameObject adContent;

    public int playerLives;
    public GameObject livesText;

    void Start()
    {
        playerLives = 3;
        
        closeButton.GetComponent<Button>().onClick.AddListener(CloseAd);
        adContent.GetComponent<Button>().onClick.AddListener(LoseLives);
    }

    private void Update()
    {
        livesText.GetComponent<TextMeshProUGUI>().text = "Lives: " + playerLives.ToString();

        if (playerLives == 0)
        {
            //add scene reload code here
        }
    }

    void CloseAd()
    {
        adContent.SetActive(false);
    }

    void LoseLives()
    {
        playerLives--;
        //Debug.Log("Life lost");
    }

    void GameOver()
    {
     
    }
}

