﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightActivator : MonoBehaviour
{
    private Collider trigger;
    private AudioSource audioSource;

    private void Awake()
    {
        trigger = GetComponent<Collider>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        //DesactivateFire();
    }

    public void DesactivateFire()
    {
        audioSource.mute = true;
        trigger.enabled = false;
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
    }

    public void ActivateFire()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        trigger.enabled = true;
        audioSource.mute = false;
    }
}
