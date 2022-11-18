using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
    private ParticleSystem particle;
    void Start()
    {
        GameObject child = transform.Find("Particle System").gameObject;
        particle = child.GetComponent<ParticleSystem>();
        particle.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("何かにぶつかった");
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemyにつかまった");
            //うごきとめる
            //少しして破壊
            Invoke("Test1", 1.0f);　// 関数Test1を3秒後に実行
            //シーン遷移　リスタート
            Invoke("Test2", 3.0f);　// 関数Test1を3秒後に実行

        }
    }


    void Test1()
    {
        MeshRenderer mesh = this.gameObject.GetComponent<MeshRenderer>();
        if (mesh != null) mesh.enabled = false;
        particle.Play();

    }
    void Test2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

