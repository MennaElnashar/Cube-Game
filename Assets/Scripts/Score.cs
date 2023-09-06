using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI scoreText;
    void FixedUpdate()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
