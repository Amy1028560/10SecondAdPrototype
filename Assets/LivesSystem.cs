using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesSystem : MonoBehaviour
{
    public int playerLives;
    public GameObject livesText;

    // Start is called before the first frame update
    void Start()
    {
        playerLives = 3; 
    }

    // Update is called once per frame
    void Update()
    {
        livesText.GetComponent<TextMeshProUGUI>().text = "Lives: " + playerLives.ToString();

        if (playerLives == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
