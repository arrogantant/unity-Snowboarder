using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] float Invoketime = 1f;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            Invoke("Relord",Invoketime);
        }
    }

    void Relord()
    {
        SceneManager.LoadScene(0);
    }
}
