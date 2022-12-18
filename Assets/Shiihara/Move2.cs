using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    //[SerializeField] GameObject Player;
    //private Rigidbody rb;
    private float upForce;
    private float distance;
    private float m_force;

    float inputHorizontal;
    float inputVertical;
    Rigidbody rb;

    float moveSpeed = 10f;

    void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody>();
        upForce = 150;
        distance = 1.0f;
        m_force = 5.0f;



    }





    void Update()
    {

        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");


        /*
        Vector3 force = new Vector3(0.0f, 0.0f, 0.0f);

        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody���擾
        // ���Ɉړ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            force = new Vector3(-m_force, 0.0f, 0.0f);    // �͂�ݒ�
            //rb.AddForce(force);
        }
        // �E�Ɉړ�
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            force = new Vector3(m_force, 0.0f, 0.0f);    // �͂�ݒ�
            //rb.AddForce(force);
        }
        // �O�Ɉړ�
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            force = new Vector3(0.0f, 0.0f, m_force);    // �͂�ݒ�
            //rb.AddForce(force);
        }
        // ���Ɉړ�
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            force = new Vector3(0.0f, 0.0f, -m_force);    // �͂�ݒ�
            //rb.AddForce(force);
        }
        else
        {
            force = new Vector3(0.0f, 0.0f, 0.0f);
        }



        rb.AddForce(force);
        */

        
        Vector3 rayPosition = transform.position + new Vector3(0.0f, 0.0f, 0.0f);
        Ray ray = new Ray(rayPosition, Vector3.down);
        bool isGround = Physics.Raycast(ray, distance);
        Debug.DrawRay(rayPosition, Vector3.down * distance, Color.red);



        if (!isGround)
        {
            rb.AddForce(new Vector3(0, -(float)(10), 0));
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (isGround)
                rb.AddForce(new Vector3(0, upForce, 0));

        }
        


        // �J�����̕�������AX-Z���ʂ̒P�ʃx�N�g�����擾
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        // �����L�[�̓��͒l�ƃJ�����̌�������A�ړ�����������
        Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;

        // �ړ������ɃX�s�[�h���|����B�W�����v�◎��������ꍇ�́A�ʓrY�������̑��x�x�N�g���𑫂��B
        //rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);
        rb.AddForce(moveForward * moveSpeed);

    }

    void FixedUpdate()
    {
        // �J�����̕�������AX-Z���ʂ̒P�ʃx�N�g�����擾
       // Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        // �����L�[�̓��͒l�ƃJ�����̌�������A�ړ�����������
        //Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;

        // �ړ������ɃX�s�[�h���|����B�W�����v�◎��������ꍇ�́A�ʓrY�������̑��x�x�N�g���𑫂��B
        //rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);
        //rb.AddForce(moveForward * moveSpeed);

        // �L�����N�^�[�̌�����i�s������
        /*if (moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }*/
    }
}