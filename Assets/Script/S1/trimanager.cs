//====================|| by meicuo ||====================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trimanager : MonoBehaviour
{
    public static trimanager Instance;
    public bool shourenbool = false;
    public bool dijingbool = false;

    public bool resetbool = false;
    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log(shourenbool);
            Debug.Log(dijingbool);

        }
    }
}
//====================|| by meicuo ||====================