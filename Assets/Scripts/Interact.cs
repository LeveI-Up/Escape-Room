using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{

    private DisplayImage currentDisplay;
    // Start is called before the first frame update
    void Start()
    {
        currentDisplay = GameObject.Find("diplayImage").GetComponent<DisplayImage>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
