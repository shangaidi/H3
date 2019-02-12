//====================|| by meicuo ||====================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text score_Text;
    public CanvasGroup score_text;
    public Image HP;
    public float hp = 100;
    private float maxhp = 100;
    public GameObject score_Image;

    public static GameManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        score_text.alpha = 0;
    }
    public void Update()
    {
        
        score_Text.text = score.ToString();
        if (score>0)
        {
            score_text.alpha = 1;
            score_Image.SetActive(true);
        }
        if (hp<0)
        {
            hp = 0;           
        }
        health();
    }
    public void health()
    {
        HP.fillAmount = hp / maxhp;
    }
}
//====================|| by meicuo ||====================