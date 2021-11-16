using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberLock : MonoBehaviour
{
    public string Password;
    private Sprite[] numberSprites;
    public int[] currentIndividualIndex= {0,0,0,0};

    void Start()
    {
        LoadAllNumberSprites();
    }
    void LoadAllNumberSprites()
    {
        numberSprites = Resources.LoadAll<Sprite>("Sprites/numbers");
    }

}
