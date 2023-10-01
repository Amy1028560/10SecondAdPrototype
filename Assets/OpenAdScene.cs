using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenAdScene : MonoBehaviour
{
    
    public void LoadAdSceneOnClick()
    {
        SceneManager.LoadScene("AdScene");
    }
}
