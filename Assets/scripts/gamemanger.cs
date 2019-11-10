using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanger : MonoBehaviour {

    public Text scoreText;
    private int score1;
    private int score2;
    public Text winScreen;
    public GameObject ball;
   

// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score1 >= 3)
        {
            winScreen.gameObject.SetActive(true);
            winScreen.text = "Player 1 Wins";
            ball.SetActive(false);
        }
        if (score2 >= 3)
        {
            winScreen.gameObject.SetActive(true);
            winScreen.text = "Player 2 Wins";
            ball.SetActive(false);
        }
    }
    public void updatescore(int player)
    {
        if (player == 1)
        {
            score1 = score1 + 1;
        }
        if (player == 2)
        {
            score2 = score2 + 1;
        }
        scoreText.text = score1 + " - " + score2;
    }
}
