using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage2 : MonoBehaviour
{

    // Start is called before the first frame update
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("âΩÇ©Ç…Ç‘Ç¬Ç©Ç¡ÇΩ");
        if (collision.gameObject.tag == "Enemy")
        {
            //Debug.Log("EnemyÇ…Ç¬Ç©Ç‹Ç¡ÇΩ");
            //Ç§Ç≤Ç´Ç∆ÇﬂÇÈ
            //Time.timeScale = 0.1f;//éûä‘íxÇ≠
            //è≠ÇµÇµÇƒîjâÛ
            Invoke("Test1", 0.1f);


        }
    }


    void Test1()
    {
        Time.timeScale = 0.1f;
        MeshRenderer mesh = this.gameObject.GetComponent<MeshRenderer>();
        if (mesh != null) mesh.enabled = false;


    }
}

