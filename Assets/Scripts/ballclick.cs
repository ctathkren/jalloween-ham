using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ballclick : MonoBehaviour
{

    public Collider2D collider;
    public AudioSource vocals;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        if (vocals.volume == 0)
        {
            StartCoroutine(FadeAudioSource.StartFade(vocals, 1f, 1f));
        }
        else if (vocals.volume == 1)
        {
            StartCoroutine(FadeAudioSource.StartFade(vocals, 1f, 0f));
        }
    }

}
