using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Damage : MonoBehaviour
{
    bool timeflag = false;
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
        if(timeflag == true)
        {

            Invoke("Test2", 3.0f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�����ɂԂ�����");
        if (collision.gameObject.tag == "Enemy")
        {
            //Debug.Log("Enemy�ɂ��܂���");
            //�������Ƃ߂�
            Time.timeScale = 0.1f;//���Ԓx��
            //�������Ĕj��
            Invoke("Test1", 0.1f);
            Invoke("Test2", 0.3f);
            //�V�[���J�ځ@���X�^�[�g

        }
    }


    void Test1()
    {
        Time.timeScale = 0.1f;
        MeshRenderer mesh = this.gameObject.GetComponent<MeshRenderer>();
        if (mesh != null) mesh.enabled = false;
        particle.Play();

    }
    void Test2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

