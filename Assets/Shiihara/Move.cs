using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{


    void Update()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbody‚ğæ“¾
        // ¶‚ÉˆÚ“®
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 force = new Vector3(-4.0f, 0.0f, 0.0f);    // —Í‚ğİ’è
            rb.AddForce(force);
        }
        // ‰E‚ÉˆÚ“®
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 force = new Vector3(4.0f, 0.0f, 0.0f);    // —Í‚ğİ’è
            rb.AddForce(force);
        }
        // ‘O‚ÉˆÚ“®
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 force = new Vector3(0.0f, 0.0f, 4.0f);    // —Í‚ğİ’è
            rb.AddForce(force);
        }
        // Œã‚ë‚ÉˆÚ“®
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 force = new Vector3(0.0f, 0.0f, -4.0f);    // —Í‚ğİ’è
            rb.AddForce(force);
        }

    }
}
