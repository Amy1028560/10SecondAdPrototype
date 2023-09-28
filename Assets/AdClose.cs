using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AdClose : MonoBehaviour
{
    public GameObject closeButton;
    public GameObject adContent;

    public int playerLives; 

    void Start()
    {
        playerLives = 3; 
        
        closeButton.GetComponent<Button>().onClick.AddListener(CloseAd);
        //adContent.GetComponent<Button>().onClick.AddListener(GameOver);
    }

    private void Update()
    {
        OnMouseOver(); 
        
        if (playerLives == 0)
        {
            //add scene reload code here
        }
    }

    void CloseAd()
    {
        adContent.SetActive(false);
    }

    public void OnMouseOver()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            playerLives--;
            Debug.Log("wow cam, you fuckin' did it, dummy"); 
        }
    }

    void GameOver()
    {
     
    }
}

