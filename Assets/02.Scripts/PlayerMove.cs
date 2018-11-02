using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float moveSpeed = 7.0f;
    public float rotSpeed = 5.0f;

    public Camera cam;

    public Transform target; // 추적할 대상
    public float dist = 5f; //거리

    public float xSpeed = 220.0f;
    public float ySpeed = 100.0f;

    private Vector3 AxisVec; // 축의 벡터
    private Vector3 Gap; // 회전 축적 값;

    public float x = 0.0f;
    public float y = 0.0f;

    public float yMinLimit = -20f;
    public float yMaxLimit = 80f;

    float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }



    // Use this for initialization
    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
    }

    // Update is called once per frame
    void Update()
    {
        RotCtrl();

        if (target)
        {
            dist -= .5f * Input.mouseScrollDelta.y; //마우스 스크롤과의 거리계산

            //마우스 스크롤 했을 경우 카메라 거리의 min, max
            if (dist < 0.5)
            {
                dist = 1;
            }

            if (dist >= 20)
            {
                dist = 20;
            }

            y = ClampAngle(y, yMinLimit, yMaxLimit);
            Quaternion rotation = Quaternion.Euler(y, x, 0);
            Vector3 position = rotation * new Vector3(0, 0.0f, -dist) + target.position + new Vector3(0.0f, 0, 0.0f);

            transform.rotation = rotation;
            transform.position = position;


        }
    }

    

    void RotCtrl()
    {

        if (Input.GetMouseButton(1))
        {
            //Debug.Log("??????");
            float yRot = Input.GetAxis("Mouse X") * rotSpeed;
            float xRot = Input.GetAxis("Mouse Y") * rotSpeed;


            this.transform.localRotation *= Quaternion.Euler(0, yRot, 0);
            cam.transform.localRotation *= Quaternion.Euler(-xRot, 0, 0);
        }

        if (Input.GetKey(KeyCode.J))
        {
            //Debug.Log("??");
            float yRot = Input.GetAxis("Mouse X") * rotSpeed;
            float xRot = Input.GetAxis("Mouse Y") * rotSpeed;


            this.transform.localRotation *= Quaternion.Euler(0, yRot, 0);
            cam.transform.localRotation *= Quaternion.Euler(-xRot, 0, 0);
        }






    }
}