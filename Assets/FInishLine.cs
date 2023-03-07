using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FInishLine : MonoBehaviour
{
    [SerializeField] float Invoketime = 1f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("Relord", Invoketime);
        }
    }

    void Relord()
    {
        SceneManager.LoadScene(0);
    }
}
