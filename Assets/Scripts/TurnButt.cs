using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnButt : MonoBehaviour
{
    public float turnDir;
    private bool heldDown;

    public void HeldDown()
    {
        heldDown = true;
    }

    public void LetUp()
    {
        heldDown = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (heldDown)
        {
            CarController.instance.Turn(turnDir);
        }
    }
}
