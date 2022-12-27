using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Toemerald : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    public void OnClickStartButton()
    {
        audioSource.PlayOneShot(sound1);
        Invoke(nameof(DelayMethod), 0.8f);
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void DelayMethod()
    {

        SceneManager.LoadScene("Emerald");
    }
}
