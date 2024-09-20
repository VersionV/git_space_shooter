using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
    
{
    // Start is called before the first frame update

    public float speed = 0.04f;
    public float decalMove = 0.04f;
    public float startTime = 0f;
    public float endTime = 3f;
    void Start()
    {
        startTime = 0f;
       
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + decalMove * Time.deltaTime, transform.position.z);
        startTime = startTime + Time.deltaTime;
        if (startTime > endTime)
        {   
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D autreobjet)
        {
            
            Destroy(autreobjet.gameObject);
            Destroy(gameObject);

    }
    } 

