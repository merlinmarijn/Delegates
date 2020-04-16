using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundEffects : MonoBehaviour
{
    private AudioSource AS;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        AS = GetComponent<AudioSource>();
        player.Pickup += PlayEffect;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayEffect()
    {
        AS.Play();
    }
}
