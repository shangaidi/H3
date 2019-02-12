//====================|| by meicuo ||====================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Test : MonoBehaviour
{
    public GameObject[] _enemys;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(INSTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void enemyGOs()
    {
        int index = Random.Range(0, _enemys.Length);
        for (int i = 0; i < _enemys.Length;i++)
        {
            if (i == index)
            {
                Instantiate(Resources.Load("Attack"), _enemys[i].transform.position, Quaternion.identity);
            }
            //break;
        }
        StartCoroutine(enemyovers());
    }
    private void enemyBacks()
    {
        Debug.Log("die");
        StartCoroutine(INSTimer());
    }
    IEnumerator INSTimer()
    {
        yield return new WaitForSeconds(1f);
        enemyGOs();

    }
    IEnumerator enemyovers()
    {
        yield return new WaitForSeconds(0.5f);
        enemyBacks();
    }
}
//====================|| by meicuo ||====================