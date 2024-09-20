using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class parallax_left : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform backgroundTransform;
    public float speed;
    public float decalMove;
    void Start()
    {
        backgroundTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        backgroundTransform.position = new Vector3(backgroundTransform.position.x, backgroundTransform.position.y - decalMove * Time.deltaTime, backgroundTransform.position.z);

        if (backgroundTransform.position.y < -10.132545f)
        {
            backgroundTransform.position = new Vector3(-10.265f, 10.24f, 0f);
        };

    }
}
