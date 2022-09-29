using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class playerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager end;
    public bergerak movement;
    public TMP_Text score;
    public TMP_Text gameover;

    // public GameManager gameManager;
    void OnCollisionEnter(Collision collisionInfo)
    {
        // Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Obstacle") // mengambil dari tag name
        {
            // GetComponent<bergerak>().enabled = false;
            gameover.enabled = true;
            score.enabled = false;
            movement.enabled = false; // jika player menabrak sesuatu maka akan berhenti
            Debug.Log("culek");
            FindObjectOfType<GameManager>().Restart(); //menlajankan fungsi endgame() yang berada di script GameManager
        };
    }
}
