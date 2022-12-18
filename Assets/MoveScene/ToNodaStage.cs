using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNodaStage : MonoBehaviour
{

    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Noda Stage");
    }
}
