using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hits : MonoBehaviour
{
    public GameObject attack1Box, attack2Box;
    public KeyCode Attack1 = KeyCode.K;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(Attack1))
        {
            attack1Box.gameObject.SetActive(true);
        }
    }
}
