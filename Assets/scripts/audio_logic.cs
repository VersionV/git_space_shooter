using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_logic : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip lazer_shot;
    private bool isGameOver = false;
    void Start()
    {
        source.clip = lazer_shot;
        source.volume = 0.4f;  
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver && Input.GetKeyDown(KeyCode.Mouse0))
        {
            source.PlayOneShot(lazer_shot);
        }
    }

    public void SetGameOver()
    {
        isGameOver = true;
    }
}
