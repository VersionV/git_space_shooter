using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour

{
    // Start is called before the first frame update
    [SerializeField]
    private int scoreTotal;
    [SerializeField]
    private TextMeshProUGUI scoreIHM;

    void Start()
    {
        
    }

    // Update is called once per frame
   public void incScore(int score)
    {
        scoreTotal += score;
        scoreIHM.text = "Score : "+scoreTotal.ToString();
    }
}
