//====================|| by meicuo ||====================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject shouren;
    public GameObject dijing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trimanager.Instance.shourenbool==true&& trimanager.Instance.dijingbool == false)
        {
            shouren.SetActive(true);
            dijing.SetActive(false);
        }
        else if (trimanager.Instance.shourenbool == false && trimanager.Instance.dijingbool == true)
        {
            shouren.SetActive(false);
            dijing.SetActive(true);
        }
        else
        {
            shouren.SetActive(true);
            dijing.SetActive(false);
        }
    }
}
//====================|| by meicuo ||====================