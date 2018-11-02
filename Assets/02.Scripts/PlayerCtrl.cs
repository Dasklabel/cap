using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCtrl : MonoBehaviour {

    private Transform tr;
    private Animator animator;
    public float moveSpeed = 5.0f;
    public float moveRun = 10.0f;
    private Vector3 moveDir;
    //public float jumpPower = 7;


    public float Speed;


    void Start()
    {
        tr = GetComponent<Transform>();
        animator = GetComponent<Animator>();
  
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        animator.SetFloat("Speed", h * h + v * v);

        moveDir = v * Vector3.forward + h * Vector3.right;


        if (Input.GetKey(KeyCode.T))
        {
            animator.SetBool("isHello", true);
        }
        else
        {
            animator.SetBool("isHello", false);
        }

        if (Input.GetKey(KeyCode.W))
        {
            tr.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), 1);
            tr.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

            if(Input.GetKey(KeyCode.LeftShift))
            {
                tr.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), 1);
                tr.Translate(Vector3.forward * Time.deltaTime * moveRun);

                animator.SetBool("isRun", true);

            }
                
            else
            {
                animator.SetBool("isRun", false);
                
            }

            animator.SetBool("isMove", true);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            tr.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), 1);
            tr.Translate(Vector3.back * Time.deltaTime * -moveSpeed);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                tr.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), 1);
                tr.Translate(Vector3.back * Time.deltaTime * -moveRun);

                animator.SetBool("isRun", true);
            }
            else
            {
                animator.SetBool("isRun", false);
            }

            animator.SetBool("isMove", true);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            tr.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), 1);
            
            tr.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                tr.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), 1);
                tr.Translate(Vector3.forward * Time.deltaTime * moveRun);

                animator.SetBool("isRun", true);
            }
            else
            {
                animator.SetBool("isRun", false);
            }

            animator.SetBool("isMove", true);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            tr.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), 1);
            tr.Translate(Vector3.forward * Time.deltaTime * moveSpeed);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                tr.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), 1);
                tr.Translate(Vector3.forward * Time.deltaTime * moveRun);

                animator.SetBool("isRun", true);
            }
            else
            {
                animator.SetBool("isRun", false);
            }

            animator.SetBool("isMove", true);

        }
        else
        {
            animator.SetBool("isMove", false);
        }
    }


    

}
