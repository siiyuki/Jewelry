using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{


        private Rigidbody rb;
        private int upForce;
        private float distance;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            upForce = 100;
            distance = 1.0f;
        }





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
