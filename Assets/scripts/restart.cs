using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour
{
    [SerializeField] private GameObject restartButton;

    private void Start()
    {
        // Assurez-vous que le bouton est caché au démarrage
        if (restartButton != null)
        {
            restartButton.SetActive(false);
        }
    }
    public void RestartGame()
    {
        Time.timeScale = 1; // Rétablir le temps normal du jeu
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Recharger la scène actuelle
    }
}
