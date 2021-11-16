using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayImage : MonoBehaviour
{
    private int currentWall;
    private int prevWall;

    public int CurrentWall
    {
        get
        {
            return currentWall;
        }

        set
        {
            if (value == 5)
            {
                currentWall = 1;
            }
            else if (value == 0)
            {
                currentWall = 4;
            }
            else
            {
                currentWall = value;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
            prevWall = 0;
            currentWall = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentWall != prevWall)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/wall" + currentWall.ToString());
        }
        prevWall = currentWall;
    }
}


        
    
