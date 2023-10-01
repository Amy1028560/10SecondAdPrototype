using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenCreditScene : MonoBehaviour
{
   
    public void LoadCreditSceneOnClick()
    {
        SceneManager.LoadScene("CreditScene");
    }
}
