using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backzukan : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    public void OnClickStartButton()
    {
        audioSource.PlayOneShot(sound1);
        Invoke(nameof(DelayMethod), 0.8f);
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void DelayMethod()
    {
        SceneManager.LoadScene("Zukan");
    }
}