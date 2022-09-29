
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class scores : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform player;
    // public Text scoreText;
    public TMP_Text score;
    // Update is called once per frame
    void Update()
    {
        // score = GetComponent<TMP_Text>();
        score.text = player.position.z.ToString(); // menampilkan score
        // Debug.Log(player.position.z);
    }
}
