
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Tracker backboard;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = Time.time.ToString("0");
        scoreText.text = backboard.score.ToString("0");
    }
}
