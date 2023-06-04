using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerGameplay : MonoBehaviour
{
    public TextMeshProUGUI scoreLabel;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateScore(int newScore)
    {
        score = newScore;
        scoreLabel.text = $"Score: {score}";
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Pickup") return;
        
        Destroy(collision.gameObject);
        UpdateScore(score+1);
    }
    
}
