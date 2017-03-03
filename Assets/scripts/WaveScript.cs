using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveScript : MonoBehaviour
{// Use this for initialization
    private EnemySpawnerStrategy strategy;
    private EnemyExtensionScript extension;

        float spawnTimer = 7f;
        float timer = 0f;
        int waveNumber = 0;

        public void Update()
        {
            timer += Time.deltaTime;
            if (timer >= spawnTimer)
            {
                Spawner();
            }
        }

     public void Spawner()
        {
            //Switches are cleaner than using many ifs when checking one variable.
            switch (waveNumber)
            {
                case 0: //If waveNumber == 0
                    //Spawn first wave
                    if (waveNumber == 0)
                    {
                    strategy = gameObject.AddComponent<EnemySpawnerStrategy>();
                    strategy.UpdateStrategy();
                    }
                    break; //End switch
                case 1:
                    //Spawn second wave
                    if (waveNumber == 1)
                    {
                    extension.gameObject.AddComponent<EnemyExtensionScript>();
                    extension.UpdateStrategy();
                    }
                    break;
            }
            ++waveNumber; //Increment by 1. Same as:  waveNumber = waveNumber + 1;
            timer = 0f;

            //Optional, randomize wave times.
            spawnTimer = Random.Range(7f, 10f);
        }
    }
