using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enemy_Ships : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform enemyTransform;
    
    public float decalMove = 0.04f;
    
    void Start()
    {
        enemyTransform = GetComponent<Transform>();
    }

  
    // Update is called once per frame
    void Update()
    {
        enemyTransform.position = new Vector3(enemyTransform.position.x, enemyTransform.position.y - decalMove * Time.deltaTime, enemyTransform.position.z);

        if (enemyTransform.position.y < -5.50f )
        {
            enemyTransform.position = new Vector3(Random.Range(-5f,5f), 7f, enemyTransform.position.z);
        }
    }
}
