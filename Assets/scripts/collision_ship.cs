using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collision_Ship : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int lifePoints = 3;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private Controller playerController;
    [SerializeField] private audio_logic audioManager;
    [SerializeField] private GameObject restartButton;


    void Start()
    {
        lifePoints = 3;
        if (gameOverUI != null)
            gameOverUI.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D autreobjet)
    {
        Destroy(autreobjet.gameObject); // Détruit l'objet entré en collision avec le vaisseau
        lifePoints--; // Réduit les points de vie de 1

        if (lifePoints <= 0)
        {
            GameOver(); // Appelle la fonction GameOver si les points de vie atteignent 0
        }
        else
        {
            Debug.Log("Points de vie restants : " + lifePoints); // Affiche les points de vie restants dans la console
        }
    }

    private void GameOver()
    {
        Debug.Log("Game Over !"); // Affiche "Game Over !" dans la console

        if (gameOverUI != null)
            gameOverUI.SetActive(true); // Affiche l'UI de Game Over

        if (audioManager != null)
            audioManager.SetGameOver();

        if (restartButton != null)
            restartButton.SetActive(true);

        Time.timeScale = 0; // Met le jeu en pause en arrêtant le temps du jeu

        GetComponent<Renderer>().enabled = false; // Rend le vaisseau invisible
                                                  
        if (playerController != null)
            playerController.enabled = false;
    }
}
