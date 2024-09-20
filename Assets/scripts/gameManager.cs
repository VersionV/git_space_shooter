using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour

{
    // Start is called before the first frame update
    [SerializeField] private float timer = 0f;
    [SerializeField] private GameObject prefabEnemy;
    [SerializeField] private GameObject prefabEnemy2;
    [SerializeField] private GameObject prefabEnemy3;

    private float LastSpawn = 0f;
    [SerializeField] private float SpawnRate = 0f;

    void Start()
    {
        timer = 0;
        spawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        // Quand le timer dépasse le moment de spawn (inc de 2)
        if (timer> LastSpawn + SpawnRate)
        {
            spawnEnemy();
            LastSpawn = timer;
        }
    }

    void spawnEnemy()
    {
        Instantiate(prefabEnemy, new Vector3(Random.Range(-5.50f, 5.50f), 7, 0), Quaternion.identity);
        Instantiate(prefabEnemy2, new Vector3(Random.Range(-5.50f, 5.50f), 7, 0), Quaternion.identity);
        Instantiate(prefabEnemy3, new Vector3(Random.Range(-5.50f, 5.50f), 7, 0), Quaternion.identity);



    }
}
