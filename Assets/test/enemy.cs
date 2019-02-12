//====================|| by meicuo ||====================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject[] _enemys;
    public GameObject[] enemypos;

    public GameObject activeEnemy = null;
    private int Timer = 0;
    

    void Start()
    {
        foreach (GameObject _enemy in _enemys)
        {
            _enemy.GetComponent<BoxCollider>().enabled = false;
            _enemy.SetActive(false);
        }

        StartCoroutine(INSTimer());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
           
        }
        
        
    }
    private void enemyGO()
    {
        int index = Random.Range(0, _enemys.Length);
        for (int i = 0; i < _enemys.Length; i++)
        {
            if (i==index)
            {
                Instantiate(Resources.Load("Cube"), _enemys[i].transform.position, Quaternion.identity);
            }
            break;
        }
        activeEnemy = _enemys[index];
        activeEnemy.SetActive(true);
        activeEnemy.GetComponent<BoxCollider>().enabled = true;
        StartCoroutine(enemyover());

    }
    private void enemyBack()
    {
        if (activeEnemy != null)
        {
            activeEnemy.GetComponent<BoxCollider>().enabled = false;
            activeEnemy.SetActive(false);
            activeEnemy = null;
        }
        StartCoroutine(INSTimer());
    }
    IEnumerator INSTimer()
    {
        yield return new WaitForSeconds(1f);
        enemyGO();
        //for (int i = 0; i < _enemy.Length; i++)
        //{
        //        Instantiate(Resources.Load("Cube"), _enemy[Timer].transform.position, Quaternion.identity);
        //    break;
        //}
    }
    IEnumerator enemyover()
    {
        yield return new WaitForSeconds(1f);
        enemyBack();
    }
}
//====================|| by meicuo ||====================