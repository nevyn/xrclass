using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerGameplay : MonoBehaviour
{
    public TextMeshProUGUI scoreLabel;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreLabel.text = $"Score: {score}";
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;

        if(other.tag != "Pickup")
            return;

        // 1. update the label with the new score
        score = score + 1;
        scoreLabel.text = $"Score: {score}";   
           
        // 2. Destroy() the thing you collided with
        Destroy(other);
    }

}
