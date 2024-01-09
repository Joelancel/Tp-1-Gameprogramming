using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RDM_spawn : MonoBehaviour
{
    public GameObject meteore_prefab;
    void Start()
    {
        InvokeRepeating("RepeatFunction", 0f, 1f);
    }
    void RepeatFunction()
    {
        if (meteore_prefab != null)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-7f, 7f), 5f, Random.Range(-0f, 0f));
            GameObject meteorInstance = Instantiate(meteore_prefab, randomSpawnPosition, Quaternion.identity);
        }
    }
}



