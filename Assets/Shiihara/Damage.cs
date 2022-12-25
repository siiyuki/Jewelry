using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Damage : MonoBehaviour
{
        [SerializeField] GameObject No0;
        [SerializeField] GameObject No1;
        [SerializeField] GameObject No2;
        [SerializeField] GameObject No3;
        [SerializeField] GameObject No4;
        [SerializeField] GameObject No5;
        [SerializeField] GameObject No6;
        [SerializeField] GameObject No7;
        [SerializeField] GameObject No8;
        [SerializeField] GameObject No9;
        [SerializeField] GameObject No10;
        [SerializeField] GameObject No11;
    bool timeflag = false;

    public AudioClip sound1;
    AudioSource audioSource;
    // Start is called before the first frame update
    [SerializeField]private ParticleSystem particle;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
       // Debug.Log("何かにぶつかった");
        if (collision.gameObject.tag == "Enemy")
        {
            //Debug.Log("Enemyにつかまった");
            //うごきとめる
            Time.timeScale = 0.1f;//時間遅く
            //少しして破壊
            Invoke("Test1", 0.01f);
            Invoke("Test2", 0.1f);
            //シーン遷移　リスタート

        }
    }


    void Test1()
    {
       
       MeshRenderer mesh = No0.GetComponent<MeshRenderer>();
       if (mesh != null) mesh.enabled = false;
       mesh = No1.GetComponent<MeshRenderer>();
        if (mesh != null) mesh.enabled = false;
        mesh = No2.GetComponent<MeshRenderer>();
        if (mesh != null) mesh.enabled = false;
        mesh = No3.GetComponent<MeshRenderer>();
        if (mesh != null) mesh.enabled = false;
        mesh = No4.GetComponent<MeshRenderer>();
        if (mesh != null) mesh.enabled = false;
        mesh = No5.GetComponent<MeshRenderer>();
        if (mesh != null) mesh.enabled = false;
        mesh = No6.GetComponent<MeshRenderer>();
        if (mesh != null) mesh.enabled = false;
        mesh = No7.GetComponent<MeshRenderer>();
        if (mesh != null) mesh.enabled = false;
        mesh = No8.GetComponent<MeshRenderer>();
        if (mesh != null) mesh.enabled = false;
        mesh = No9.GetComponent<MeshRenderer>();
        if (mesh != null) mesh.enabled = false;
        mesh = No10.GetComponent<MeshRenderer>();
        if (mesh != null) mesh.enabled = false;
        mesh = No11.GetComponent<MeshRenderer>();
        if (mesh != null) mesh.enabled = false;
        audioSource.PlayOneShot(sound1);
        particle.Play();

    }
    void Test2()
    {
        Time.timeScale =1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

