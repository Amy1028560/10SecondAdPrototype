using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdClose : MonoBehaviour
{
    public GameObject closeButton;
    public GameObject adContent;
    public GameObject entireAd; 

    public GameObject livesLink; 

    void Start()
    {
        closeButton.GetComponent<Button>().onClick.AddListener(CloseAd);
        adContent.GetComponent<Button>().onClick.AddListener(LoseLives);
    }

    private void Update()
    {
        
    }

    void CloseAd()
    {
        entireAd.SetActive(false);
    }

    void LoseLives()
    {
        livesLink.GetComponent<LivesSystem>().playerLives--;
        Debug.Log("Life lost lol");
    }

    void GameOver()
    {
     
    }
}

