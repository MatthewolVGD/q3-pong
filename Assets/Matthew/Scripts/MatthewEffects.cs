using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatthewEffects : MonoBehaviour
{
    /*
    public float rotateSpeed;
    public float minRotAmount;
    public float maxRotAmount;
    public float effectSpawnTimer;
    float ogeffectSpawnTime;
    public float spawnLiveTime;
    float ogLiveTime;

    // Start is called before the first frame update
    void Start()
    {
        ogeffectSpawnTime = effectSpawnTimer;
        ogLiveTime = spawnLiveTime;
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
        spawnLiveTime -= Time.deltaTime;
        if (spawnLiveTime <= 0)
        {
            
        }
    }
    void SpawnEffect()
    {
        GameObject[] PowerUps;
        PowerUps = GameObject.FindGameObjectsWithTag("Powerup");
        int spawn = Random.Range(0, PowerUps.Length);
        float spawnY = Random.Range
                (Camera.main.ScreenToWorldPoint(new Vector2(0, 3)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height - 3)).y);
        float spawnX = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(3, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width - 3, 0)).x);

        Vector2 spawnPosition = new Vector2(spawnX, spawnY);

        GameObject powerUp = Instantiate(PowerUps[spawn], spawnPosition, Quaternion.identity);
        spawnLiveTime = ogLiveTime;
    }

    public void PowerUp(string PowerUpName)
    {
        if (PowerUpName.Contains("CameraSpin"))
        {
            Camera cam = Camera.main;
            float rotAmount = Random.Range(minRotAmount, maxRotAmount + 1);
            Vector3 rotateAmount = new Vector3(0, 0, Random.Range(minRotAmount, maxRotAmount + 1));
            cam.transform.Rotate(Vector3.forward * rotAmount);
        }
    }*/
}
