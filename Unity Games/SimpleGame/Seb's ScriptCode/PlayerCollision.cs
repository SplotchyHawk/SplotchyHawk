
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public movement isMoving;
    public GameManager gameManager;
    //public Text scoreText;


    void OnCollisionEnter(Collision info)
    {
        if (info.collider.tag == "Obstacle")
        {
            Debug.Log("We hit something captain!");
            isMoving.enabled = false;
            gameManager.Endgame();
            //scoreText = 0;
        }
    }
}
