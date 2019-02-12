//====================|| by meicuo ||====================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tx : MonoBehaviour
{
    public GameObject _tx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(timer());
    }
    IEnumerator timer()
    {
        _tx.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        _tx.SetActive(false);
    }
}
//====================|| by meicuo ||====================