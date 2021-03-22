using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatthewEffects : MonoBehaviour
{
    public float rotateSpeed;
    public float minRotAmount;
    public float maxRotAmount;
    public float effectSpawnTimer;
    float ogeffectSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        ogeffectSpawnTime = effectSpawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        effectSpawnTimer -= Time.deltaTime;
        if (effectSpawnTimer <= 0f)
        {
            SpawnEffect();
            effectSpawnTimer = ogeffectSpawnTime;
        }
    }
    void SpawnEffect()
    {
        GameObject[] PowerUps;
        PowerUps = GameObject.FindGameObjectsWithTag("Powerup");
        int spawn = Random.Range(0, PowerUps.Length);
        Instantiate(PowerUps[spawn]);

    }
}
