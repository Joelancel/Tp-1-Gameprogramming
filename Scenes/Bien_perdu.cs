using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bien_perdu : MonoBehaviour
{
    
    public string nomDeLaNouvelleScene2 = "scene_2";
    void Start()
    {
        StartCoroutine(LoadSecondSceneAfterDelay(5f));
 
    }

    IEnumerator LoadSecondSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(nomDeLaNouvelleScene2);
    }

}
