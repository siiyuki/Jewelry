using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{


        private Rigidbody rb;
        private int upForce;
        private float distance;
        private float m_force;

        void Start()
        {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody>();
            upForce = 50;
            distance = 1.0f;
            m_force = 5.0f;
        }





        void Update()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody���擾
        // ���Ɉړ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 force = new Vector3(-m_force, 0.0f, 0.0f);    // �͂�ݒ�
            rb.AddForce(force);
        }
        // �E�Ɉړ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 force = new Vector3(m_force, 0.0f, 0.0f);    // �͂�ݒ�
            rb.AddForce(force);
        }
        // �O�Ɉړ�
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 force = new Vector3(0.0f, 0.0f, m_force);    // �͂�ݒ�
            rb.AddForce(force);
        }
        // ���Ɉړ�
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 force = new Vector3(0.0f, 0.0f, -m_force);    // �͂�ݒ�
            rb.AddForce(force);
        }




        Vector3 rayPosition = transform.position + new Vector3(0.0f, 0.0f, 0.0f);
        Ray ray = new Ray(rayPosition, Vector3.down);
        bool isGround = Physics.Raycast(ray, distance);
        Debug.DrawRay(rayPosition, Vector3.down * distance, Color.red);

        if (Input.GetKey(KeyCode.Space))
        {
            if (isGround)
                rb.AddForce(new Vector3(0, upForce, 0));
        }

    }
}
