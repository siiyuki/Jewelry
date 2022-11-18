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
        Debug.Log("�����ɂԂ�����");
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy�ɂ��܂���");
            //�������Ƃ߂�
            //�������Ĕj��
            Invoke("Test1", 1.0f);�@// �֐�Test1��3�b��Ɏ��s
            //�V�[���J�ځ@���X�^�[�g
            Invoke("Test2", 3.0f);�@// �֐�Test1��3�b��Ɏ��s

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

