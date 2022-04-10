using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelButton : MonoBehaviour
{
    public void OnDown()
    {
        CarController.instance.doAccelerate = true;
    }

    public void OnUp()
    {
        CarController.instance.doAccelerate = false;
    }
}
