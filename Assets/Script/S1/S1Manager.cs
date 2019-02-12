//====================|| by meicuo ||====================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S1Manager : MonoBehaviour
{
    public GameObject _image;
    private int timer = -1;
    public GameObject _shouren;
    public GameObject _dijing;

    public GameObject _mc;
    private int _timer = -1;
    // Start is called before the first frame update.
    private void Awake()
    {
        
    }
    void Start()
    {
        trimanager.Instance.shourenbool = false;
        trimanager.Instance.dijingbool = false;
        _shouren.SetActive(false);
        _dijing.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer>0)
        {
            _image.SetActive(true);
        }
        if (timer<0)
        {
            _image.SetActive(false);
        }
        //
        if (_timer > 0)
        {
            _mc.SetActive(true);
        }
        if (_timer < 0)
        {
            _mc.SetActive(false);
        }      
    }
    //
    public void shouren()
    {
        trimanager.Instance.shourenbool = true;
        trimanager.Instance.dijingbool = false;
        _shouren.SetActive(false);
        _dijing.SetActive(true);
    }
    public void dijing()
    {
        trimanager.Instance.shourenbool = false;
        trimanager.Instance.dijingbool = true;
        _shouren.SetActive(true);
        _dijing.SetActive(false);
    }

    //
    public void jianjie()
    {
        timer *= -1;
    }
    public void quit()
    {
        Application.Quit();
    }
    public void toS2()
    {       
        SceneManager.LoadScene("SampleScene");
    }
    public void mc()
    {
        _timer *= -1;
    }
}
//====================|| by meicuo ||====================