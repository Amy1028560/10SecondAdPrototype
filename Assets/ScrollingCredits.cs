using UnityEngine;
using UnityEngine.UI;

public class ScrollingCredits : MonoBehaviour
{
    public float scrollSpeed = 30.0f; //speed of credits moving
    private RectTransform creditsText;

    private void Start()
    {
        creditsText = GetComponent<RectTransform>();
    }

    private void Update()
    {
        // moves text up
        creditsText.anchoredPosition += Vector2.up * scrollSpeed * Time.deltaTime;
    }
}