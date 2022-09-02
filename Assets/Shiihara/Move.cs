using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{


    void Update()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody���擾
        // ���Ɉړ�
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 force = new Vector3(-4.0f, 0.0f, 0.0f);    // �͂�ݒ�
            rb.AddForce(force);
        }
        // �E�Ɉړ�
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 force = new Vector3(4.0f, 0.0f, 0.0f);    // �͂�ݒ�
            rb.AddForce(force);
        }
        // �O�Ɉړ�
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 force = new Vector3(0.0f, 0.0f, 4.0f);    // �͂�ݒ�
            rb.AddForce(force);
        }
        // ���Ɉړ�
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 force = new Vector3(0.0f, 0.0f, -4.0f);    // �͂�ݒ�
            rb.AddForce(force);
        }

    }
}
