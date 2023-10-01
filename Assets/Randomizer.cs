using TMPro; 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Randomizer : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;
    public float spawnInterval = 2.0f;
    public float spawnRadius = 5.0f; // Adjust this radius as needed.
    public float gameDuration = 10.0f; // Set the game duration in seconds.

    public float timer; 

    private Canvas canvas; // Reference to the Canvas, if needed.
    private bool canInteract = true;

    public GameObject timerDisplay; 

    private void Start()
    {
        // Find the Canvas in the scene.
        canvas = FindObjectOfType<Canvas>();

        if (canvas == null)
        {
            Debug.LogError("No Canvas found in the scene. Make sure to create a Canvas GameObject.");
            return;
        }

        // Start spawning immediately and then at intervals.
        StartCoroutine(SpawnPrefabs());

        // Start a timer to end the game after the specified duration.
        StartCoroutine(EndGameAfterDuration());

        timer = 0.0f; 
    }

    private void Update()
    {
        timerDisplay.GetComponent<TextMeshProUGUI>().text = "Time: " + (int)timer;
    }

    private IEnumerator SpawnPrefabs()
    {
        while (timer < gameDuration)
        {
            if (canInteract)
            {
                // Randomly select a prefab from the array.
                GameObject randomPrefab = prefabsToSpawn[Random.Range(0, prefabsToSpawn.Length)];

                // Randomize the spawn position within a specified radius.
                Vector3 spawnPosition = transform.position + new Vector3(Random.Range(-spawnRadius, spawnRadius), Random.Range(-spawnRadius, spawnRadius), 0);

                // Instantiate the selected prefab at the randomized position.
                GameObject spawnedPrefab = Instantiate(randomPrefab, spawnPosition, Quaternion.identity);

                // Make the spawned prefab a child of the Canvas.
                if (canvas != null)
                {
                    spawnedPrefab.transform.SetParent(canvas.transform, false);
                }
            }

            // Wait for the specified spawn interval before spawning the next prefab.
            yield return new WaitForSeconds(spawnInterval);

            timer += spawnInterval;
        }
    }

    private IEnumerator EndGameAfterDuration()
    {
        yield return new WaitForSeconds(gameDuration);

        // Disable player interaction after the game ends.
        canInteract = false;

        // Add your game-ending logic here, such as showing a game over screen or exiting the application.
        Debug.Log("Game Over");
        // Example: To exit the application after the game ends.
        // Application.Quit();
    }
}
