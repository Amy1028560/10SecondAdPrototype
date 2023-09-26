using UnityEngine;
using UnityEngine.UI;

public class AdClose : MonoBehaviour
{
    public GameObject closeButton;
    public GameObject adContent;

    void Start()
    {
        closeButton.GetComponent<Button>().onClick.AddListener(CloseAd);
        adContent.GetComponent<Button>().onClick.AddListener(GameOver);
    }

    void CloseAd()
    {
        adContent.SetActive(false);
    }

    void GameOver()
    {
        GameManager.Instance.GameOver();
    }
}

