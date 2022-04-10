using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{

    public GameObject car;
    public GameObject placeCarButton;
    public GameObject placementIndicator;
    public GameObject carControls;
    // Start is called before the first frame update
    void Start()
    {
        car.SetActive(false);
        carControls.SetActive(false);
        placeCarButton.SetActive(true);
        placementIndicator.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlaceCarButton()
    {
        car.SetActive(true);
        carControls.SetActive(true);
        placeCarButton.SetActive(false);
        placementIndicator.SetActive(false);

        car.transform.position = placementIndicator.transform.position;
    }
}
