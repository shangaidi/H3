//====================|| by meicuo ||====================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour
{
    private GameObject temp;
    private GameObject _tx;

    private float Timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        temp = GameObject.Find("Player");
        this.transform.LookAt(temp.transform);

    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer>1.5f)
        {
            Destroy(this.gameObject);
        }
        StartCoroutine(enemyTimer());
        //this.transform.LookAt(temp.transform);
    }

    IEnumerator enemyTimer()
    {
        yield return new WaitForSeconds(0.4f);

        this.transform.position=Vector3.MoveTowards(this.transform.position,temp.transform.position,0.1f);
        //向目标移动喽~
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag=="playertri")
        {            
            GameManager.Instance.score += 1;
            Destroy(this.gameObject);
            
        }
        if (other.transform.tag == "die")
        {
            GameManager.Instance.hp -= 40;
            Destroy(this.gameObject);
        }
    }
}
//====================|| by meicuo ||====================