using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestroy : MonoBehaviour
{
    private void OnCollisionExit(Collision other)
    {
        Destroy(other.gameObject);
    }
}
