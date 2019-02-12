//====================|| by meicuo ||====================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tx2 : MonoBehaviour
{
    public GameObject _tx2;
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
        StartCoroutine(timers());
    }
    IEnumerator timers()
    {
        _tx2.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        _tx2.SetActive(false);
    }
}
//====================|| by meicuo ||====================