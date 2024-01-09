using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    public string Asteroid = "asteroid";
    public string Scene_Perdu = "Perdu";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(Asteroid))
        {
            SceneManager.LoadScene(Scene_Perdu);
        }
    }
}


