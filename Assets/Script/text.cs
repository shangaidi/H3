//====================|| by meicuo ||====================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    public GameObject MainCream;
    private float Rotation_camera_Ori;
    private float Rotation_camera_change;
    float BianLiang = 0;

    public static bool tempbool = true;
    // Start is called before the first frame update
    void Start()
    {
        Rotation_camera_Ori = MainCream.transform.localEulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (tempbool==true)
        {
            Rotation_camera_change = MainCream.transform.localEulerAngles.y;
            if (Rotation_camera_change != Rotation_camera_Ori)
            {
                BianLiang = Rotation_camera_change - Rotation_camera_Ori;
                Rotation_camera_Ori = Rotation_camera_change;
                this.gameObject.transform.localEulerAngles = new Vector4
                    (this.gameObject.transform.localEulerAngles.x, this.gameObject.transform.localEulerAngles.y + BianLiang, this.gameObject.transform.localEulerAngles.z);
            }
        }       
    }
   
}
//====================|| by meicuo ||====================