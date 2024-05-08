using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    public float Health;
    public bool living = true;
    void Start()
    {
        Health PlayerHealth = new Health;
        PlayerHealth = 100;
        living PlayerLiving = new living;
    }

    void Update()
    {
        if (Health =< 0)
        {
            Playerliving = false;
        }
    }
}
