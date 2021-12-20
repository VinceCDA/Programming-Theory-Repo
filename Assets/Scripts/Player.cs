using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PlayerController
{
    private int _health = 10;

    public int Health
    {
        get => _health; 
        set
        {
            if (value < 0)
            {

                Debug.LogError("You can't set a negative health!");
            }
            else
            {
                _health = value;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ControlPlayer();
    }
}
