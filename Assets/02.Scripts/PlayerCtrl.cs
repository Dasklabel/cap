using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCtrl : MonoBehaviour
{

    public GameObject female;
    public GameObject male;
    public GameObject police;
    public GameObject cameraman;

    private Transform tr;
    private Animator animator;
    public float moveSpeed = 5.0f;
    public float moveRun = 10.0f;
    private Vector3 moveDir;
    public float jumpSpeed = 5.0f;
    public bool isGrounded = false;
    Rigidbody rb;

    void Start()
    {
        tr = GetComponent<Transform>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        animator.SetFloat("Speed", h * h + v * v);

        moveDir = v * Vector3.forward + h * Vector3.right;

        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, 1, 0) * jumpSpeed, ForceMode.Impulse);
                isGrounded = false;
            }
        }
        if (Input.GetKey(KeyCode.T)) // 인사
        {
            Handshake();
        }
        else
        {
            animator.SetBool("isHello", false);
        }

        if (WalkCheck())
        {
            Walk();

            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (WalkCheck())
                {
                    Run();
                }
                animator.SetBool("isRun", false);
            }
            animator.SetBool("isMove", true);


        }
        else if (Input.GetKey(KeyCode.S))
        {
            BackWalk();

            if (Input.GetKey(KeyCode.LeftShift))
            {
                Run();
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

    void Handshake()
    {
        animator.SetBool("isHello", true);
    }

    void Walk()
    {
        tr.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), 1);
        tr.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }

    void BackWalk()
    {
        tr.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), 1);
        tr.Translate(Vector3.back * Time.deltaTime * -moveSpeed);
    }

    void Run()
    {
        tr.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), 1);
        tr.Translate(Vector3.forward * Time.deltaTime * moveRun);

        animator.SetBool("isRun", true);
    }

    bool WalkCheck()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
