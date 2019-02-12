//====================|| by meicuo ||====================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int timer = -1;
    public GameObject _over;
    private void Update()
    {
        if (timer>0)
        {
            Time.timeScale = 0;
            text.tempbool = false;
            CameraFollow.camerabool = false;
        }
        if (timer<0)
        {
            Time.timeScale = 1;
            text.tempbool = true;
            CameraFollow.camerabool = true;
        }       
        if (GameManager.Instance.hp<=10)
        {
            _over.SetActive(true);
            Time.timeScale = 0;
            text.tempbool = false;
            CameraFollow.camerabool = false;
        }
    }
    public void quit()
    {
        Application.Quit();      
    }
    public void stop()
    {
        timer *=-1;
    }
    public void backs1()
    {
        trimanager.Instance.resetbool = true;
        SceneManager.LoadScene("1");
    }

}
//====================|| by meicuo ||====================