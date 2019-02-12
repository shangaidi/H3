using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestory : MonoBehaviour
{
    public GameObject[] DontDestroyObjects;//不删除的物体
    public static bool isExist;//是否存在
    void Awake()
    {
        if (!isExist)//如果不存在
        {
            for (int i = 0; i < DontDestroyObjects.Length; i++)
            {
                DontDestroyOnLoad(DontDestroyObjects[i]);//第一次将物体设为不删除
            }
            isExist = true;
        }
        else//=true 存在，删除重复的
        {
            for (int i = 0; i < DontDestroyObjects.Length; i++)
            {
                Destroy(DontDestroyObjects[i]);
            }
        }
    }
}
