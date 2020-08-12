using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Transform playerTransform;
    public Text scoreText;
    private float x;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z<=0)
        {
            x=x+1;
        }
        else
        {
            x = x +  playerTransform.position.z;
        }

        scoreText.text = x.ToString("0");
    }
}
