using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireball();
        Debug.Log("Player Health: " + x);

        int y = TakeDamageFromFireball(25);
        Debug.Log("player health " + y);

        int z = TakeDamageFromFireball(30, 50);
        Debug.Log("player health " + z);
    }
    
    // Update is called once per frame
    void Update()
    {

    }
    int TakeDamageFromFireball()
    {
        int playerhealth = 100;
        return playerhealth - 5;
    }
    int TakeDamageFromFireball(int damage)
    {
        int playerhealth = 100;
        return playerhealth - damage;
    }
    int TakeDamageFromFireball(int damage, int playerhealth)
    {
    return playerhealth - damage;
    }
}

