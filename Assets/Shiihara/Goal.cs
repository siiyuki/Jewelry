using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] GameObject Clear;
    [SerializeField] GameObject Totitle;
    bool timeflag = false;

    [SerializeField] AudioSource audioSource;
    // Start is called before the first frame update
    private ParticleSystem particle;
    [SerializeField] private AudioClip sound1;
    AudioSource audioSource2;
    void Start()
    {

        audioSource2 = GetComponent<AudioSource>();
        //audioSource = this.GetComponent<AudioSource>();
        //GameObject child = transform.Find("Particle System").gameObject;
        //particle = child.GetComponent<ParticleSystem>();
        //particle.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeflag == true)
        {

            Invoke("Test2", 3.0f);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        //Debug.Log("�����ɂԂ�����");
        if (collision.gameObject.tag == "Goal")
        {
            audioSource.Stop();
            //Debug.Log("Enemy�ɂ��܂���");
            //�������Ƃ߂�
            Time.timeScale = 0.1f;//���Ԓx��
            //�������Ĕj��
            Invoke("Test1", 0.1f);
            Invoke("Test2", 0.2f);
            //�V�[���J�ځ@���X�^�[�g

        }else if (collision.gameObject.tag == "Goal2")
        {
            audioSource.Stop();
            //Debug.Log("Enemy�ɂ��܂���");
            //�������Ƃ߂�
            Time.timeScale = 0.1f;//���Ԓx��
            //�������Ĕj��
            Invoke("Test1", 0.1f);
            Invoke("Test3", 0.2f);
            //�V�[���J�ځ@���X�^�[�g

        }
    }


    void Test1()
    {
        Time.timeScale = 1;
        //MeshRenderer mesh = this.gameObject.GetComponent<MeshRenderer>();
        //if (mesh != null) mesh.enabled = false;
        //particle.Play();

    }
    void Test2()
    {
        audioSource.PlayOneShot(sound1);
        Time.timeScale = 0f;
        Clear.SetActive(true);
        Totitle.SetActive(false);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void Test3()
    {
        Time.timeScale = 0f;
        Totitle.SetActive(false);
        SceneManager.LoadScene("Stageselect");
    }
}
