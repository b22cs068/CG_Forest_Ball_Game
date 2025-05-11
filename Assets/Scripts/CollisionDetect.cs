using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(HandleCollision());
    }

    IEnumerator HandleCollision()
    {
        // Disable player movement when a collision happens
        thePlayer.GetComponent<PlayerMovements>().enabled = false;

        // Wait for 3 seconds to simulate the delay (or any custom logic)
        yield return new WaitForSeconds(3);

        // After collision, load Scene 0 (the start menu)
        SceneManager.LoadScene(0);
    }
}
