using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSwitch : MonoBehaviour
{
    private DisplayImage currentDisplay;

    // Start is called before the first frame update
    void Start()
    {
        currentDisplay = GameObject.Find("diplayImage").GetComponent<DisplayImage>();
    }

    public void OnRightArrow()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall + 1;
    }
    public void OnLeftArrow()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall - 1;
    }
}
