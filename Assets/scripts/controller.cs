using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform playerTransform;
    public float speed = 3.0f;
    public float decalMove = 0.03f;

    

    [SerializeField] private float limitBas = -4.80f;
    [SerializeField] private float limitGauche = -4.80f;
    [SerializeField] private float limitDroite = 4.80f;
    [SerializeField] private float limitHaut = 2f;
    public GameObject projectile;
    [SerializeField] private KeyCode moveUpKey = KeyCode.UpArrow;
    [SerializeField] private KeyCode moveDownKey = KeyCode.DownArrow;
    [SerializeField] private KeyCode moveLeftKey = KeyCode.LeftArrow;
    [SerializeField] private KeyCode moveRightKey = KeyCode.RightArrow;
    
    [SerializeField] private KeyCode shootKey = KeyCode.Space;
    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if
            (Input.GetKey(moveLeftKey) && playerTransform.position.x > limitGauche)
        {
            playerTransform.position = new Vector3(playerTransform.position.x - decalMove, playerTransform.position.y, playerTransform.position.z);

           // Debug.Log("on va à gauche");
        }

        if
            (Input.GetKey(moveRightKey) && playerTransform.position.x < limitDroite)
        {
            playerTransform.position = new Vector3(playerTransform.position.x + decalMove, playerTransform.position.y, playerTransform.position.z);

            // Debug.Log("on va à droite");
        }
        if
            (Input.GetKey(moveUpKey) && playerTransform.position.y < limitHaut)
        {
            playerTransform.position = new Vector3(playerTransform.position.x , playerTransform.position.y + decalMove, playerTransform.position.z);

             //Debug.Log("on va à haut");
        }
        if
            (Input.GetKey(moveDownKey) && playerTransform.position.y > limitBas)
        {
            playerTransform.position = new Vector3(playerTransform.position.x, playerTransform.position.y - decalMove, playerTransform.position.z);
             
            // Debug.Log("on va en bas");
        }

        if (Input.GetKeyUp(shootKey))
        {
            Instantiate(projectile, playerTransform.position, Quaternion.identity);
        }
        
    }
    }
