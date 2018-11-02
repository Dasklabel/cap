using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{

    
    private Transform cam; // 메인카메라 컴포넌트
    

    public Transform target; // 추적할 대상
    public float dist = 5f; //거리

    //카메라 회전속도
    public float xSpeed = 220.0f;
    public float ySpeed = 100.0f;

    //카메라 초기 위치
    public float x = 0.0f;
    public float y = 0.0f;

    //y값 제한
    public float yMinLimit = -20f;
    public float yMaxLimit = 80f;

    private Vector3 AxisVec; // 축의 벡터
    private Vector3 Gap; // 회전 축적 값;

    //앵글의 최소 제한
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
        cam = GetComponent<Transform>();
        //Cursor.lockState = CursorLockMode.Locked; 커서 숨기기
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
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

            //x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
            //y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;

            //앵글값 정하기
            //y값의 min과 max 없애면 y값이 360도 계속 회전
            // x값은 계속 돌고 y값만 제한
            y = ClampAngle(y, yMinLimit, yMaxLimit);

            //카메라 위치 계산
            Quaternion rotation = Quaternion.Euler(y, x, 0);
            Vector3 position = rotation * new Vector3(0, 0.0f, -dist) + target.position + new Vector3(0.0f, 0, 0.0f);

            transform.rotation = rotation;
            transform.position = position;
        }
    }
}
