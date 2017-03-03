using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    private EnemySpawnerStrategy strategy;
    private EnemyExtensionScript extension;
    
    // Use this for initialization
    void Start()
    {
        if (Time.timeSinceLevelLoad == 2)
        {
            strategy = gameObject.AddComponent<EnemySpawnerStrategy>();
            strategy.StartStrategy();
        }

    }

    // Update is called once per frame
	void Update () {
		strategy.UpdateStrategy();
	}
}
