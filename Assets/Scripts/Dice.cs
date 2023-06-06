using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Scripts
{
    
public class Dice : MonoBehaviour
{ 
    private void Update()
    {
        GetRandomNumber(); 
    }

    private static int GetRandomNumber()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomNumber = Random.Range(1, 7);
            print(randomNumber);
            return randomNumber;
        }

        return 0;
    }
}
}
