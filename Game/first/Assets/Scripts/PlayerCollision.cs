using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collisionInfo)
    {
        
        if (collisionInfo.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManager>().GameOver();
            FindObjectOfType<PlayerMovement>().enabled = false;
        }
    }
}
