using UnityEngine;
using TMPro; // TextMeshPro library ko include karna zaroori hai

public class UIscore : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText; // Yahan 'Text' ki jagah 'TextMeshProUGUI' use karein

    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}