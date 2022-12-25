using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    //[SerializeField] GameObject Player;
    //private Rigidbody rb;
    [SerializeField]  private float upForce = 150f;
    [SerializeField] private float unground_move = 0.75f;

    [SerializeField]float moveSpeed = 500f;
    private float move;
    private float distance;
    //private float m_force;

    float inputHorizontal;
    float inputVertical;
    Rigidbody rb;

    public AudioClip sound1;
    AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody>();
        //upForce = 150;..
        distance = 1.0f;
        //m_force = 5.0f;



    }





    void Update()
    {

        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");


        /*
        Vector3 force = new Vector3(0.0f, 0.0f, 0.0f);

        Rigidbody rb = this.GetComponent<Rigidbody>();  // rigidbodyを取得
        // 左に移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            force = new Vector3(-m_force, 0.0f, 0.0f);    // 力を設定
            //rb.AddForce(force);
        }
        // 右に移動
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            force = new Vector3(m_force, 0.0f, 0.0f);    // 力を設定
            //rb.AddForce(force);
        }
        // 前に移動
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            force = new Vector3(0.0f, 0.0f, m_force);    // 力を設定
            //rb.AddForce(force);
        }
        // 後ろに移動
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            force = new Vector3(0.0f, 0.0f, -m_force);    // 力を設定
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



        if (isGround)
        {
            move = moveSpeed;

        }else if (!isGround)
        {
            rb.AddForce(new Vector3(0, -(float)(10), 0));
            move = unground_move * move;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (isGround)
            {
                audioSource.PlayOneShot(sound1);
                rb.AddForce(new Vector3(0, upForce, 0));
            }
        }
        
        // カメラの方向から、X-Z平面の単位ベクトルを取得
        Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        // 方向キーの入力値とカメラの向きから、移動方向を決定
        Vector3 moveForward = cameraForward * Input.GetAxis("Vertical") + Camera.main.transform.right * Input.GetAxis("Horizontal");

        // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
        //rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);
        rb.AddForce(moveForward * move* Time.deltaTime);



    }

    void FixedUpdate()
    {
        // カメラの方向から、X-Z平面の単位ベクトルを取得
       // Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;

        // 方向キーの入力値とカメラの向きから、移動方向を決定
        //Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;

        // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
        //rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);
        //rb.AddForce(moveForward * moveSpeed);

        // キャラクターの向きを進行方向に
        /*if (moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }*/
    }
}