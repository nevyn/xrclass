using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerGameplay : MonoBehaviour
{
    public TextMeshProUGUI scoreLabel;
    public GameObject sphere;
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

        float scale = 1.0f + score/10.0f;
        sphere.transform.localScale = new Vector3(scale, scale, scale);
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        if(other.tag != "Pickup") return;

        other.transform.parent = this.transform;
        Destroy(other.GetComponent<Rigidbody>());
        UpdateScore(score+1);
    }
    
}
