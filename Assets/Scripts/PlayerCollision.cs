using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movePlayer;
    public GameManager gameMan;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movePlayer.enabled = false;
            gameMan.EndGame();
        }
    }
}
