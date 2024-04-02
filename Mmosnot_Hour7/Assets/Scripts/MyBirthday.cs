using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int m = 1; m <= 12; m++)
        {
            if (m == 8)
            {
                Debug.Log("Its My Birthday");
            }
            else
            {
                Debug.Log(m);
            }
        }
        for (int d = 1; d <= 31; d++)
        {
            if (d == 1)
            {
                Debug.Log("Its My Birthday");
            }
            else
            {
                Debug.Log(d);
            }
        }
    }

// Update is called once per frame
void Update()
    {
        
    }
}
