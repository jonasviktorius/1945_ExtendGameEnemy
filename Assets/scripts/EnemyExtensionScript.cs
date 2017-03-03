using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemyExtensionScript : EnemySpawnerStrategy
{
    //private EnemySpawnerStrategy strategy;
    private Random random = new Random();
    private float spawnPercentage = 5;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//strategy.UpdateStrategy();
	}

    public override void UpdateStrategy()
    {
        base.UpdateStrategy();
        if (random.Next(100) < spawnPercentage)
        {
            Debug.Log("new strategy");
            //instansiate enemy
            GameObject randomEnemy = (GameObject)Instantiate(Resources.Load("Enemy"));
            randomEnemy.transform.position = new Vector3(3, 2, 0);
        }
    }
}
