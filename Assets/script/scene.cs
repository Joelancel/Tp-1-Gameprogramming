using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string nextSceneName;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Vous pouvez ajuster le d�clencheur selon vos besoins
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
