using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World_settings : MonoBehaviour
{
    public int dificulty;
    public int exp;
    public int score;


    private void Update()
    {
        if (exp >= 10)
        {
            exp = 0;
            dificulty++;
        }
    }
}
