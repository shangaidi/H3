//====================|| by meicuo ||====================
using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    private Vector3 followPos;//用来保存摄像机和游戏主角的相对位置
    private GameObject player;
    public float scrollSpeed = 15;//摄像机拉近的速度
    private bool isRotating = false;//判断鼠标右键是否按下
    public float rotateSpeed = 2;//摄像机左右旋转的速度
    private float distance;//保存摄像机和游戏主角距离

    public static bool camerabool = true;
    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        followPos = player.transform.position - this.transform.position;
        this.transform.LookAt(player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (camerabool==true)
        {
            Follow();
            RotateView();
            ScrollView();
        }      
    }
    //使摄像机跟随游戏主角运动
    void Follow()
    {
        this.transform.position = player.transform.position - followPos;
    }
    //滑动鼠标滑轮的时候可以改变摄像机与游戏主角的距离
    void ScrollView()
    {
        distance = followPos.magnitude;
        //-是 正常，+是反向
        distance -= Input.GetAxis("Mouse ScrollWheel");
        distance = Mathf.Clamp(distance, 2, 18);
        followPos = followPos.normalized * distance;
    }
    //按下鼠标右键的时候移动鼠标可以改变摄像机的视角
    void RotateView()
    {
        if (Input.GetMouseButtonDown(1))
        {
            isRotating = true;
        }
        else if (Input.GetMouseButtonUp(1))
        {
            isRotating = false;
        }
        if (isRotating)
        {
            this.transform.RotateAround(player.transform.position, player.transform.up, rotateSpeed * Input.GetAxis("Mouse X"));
            Vector3 originalPos = this.transform.position;
            Quaternion originalRotation = this.transform.rotation;
            this.transform.RotateAround(player.transform.position, this.transform.right, -rotateSpeed * Input.GetAxis("Mouse Y"));
            float x = this.transform.eulerAngles.x;
            //输出x值
            //print(x);
            //限制摄像机旋转的最大，最小位置
            if (x < 10 || x > 70)
            {
                this.transform.position = originalPos;
                this.transform.rotation = originalRotation;
            }
        }
        followPos = player.transform.position - this.transform.position;
    }
}
//====================|| by meicuo ||====================