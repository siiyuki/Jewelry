using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{


    void Update()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        // 左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 force = new Vector3(-4.0f, 0.0f, 0.0f);    // 力を設定
            rb.AddForce(force);
        }
        // 右に移動
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 force = new Vector3(4.0f, 0.0f, 0.0f);    // 力を設定
            rb.AddForce(force);
        }
        // 前に移動
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 force = new Vector3(0.0f, 0.0f, 4.0f);    // 力を設定
            rb.AddForce(force);
        }
        // 後ろに移動
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 force = new Vector3(0.0f, 0.0f, -4.0f);    // 力を設定
            rb.AddForce(force);
        }

    }
}
