using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class BombeController : MonoBehaviour
{

    public GameObject explosionEffect;
    public float time = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void explose()
    {
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Play();
        Destroy(gameObject, exp.main.duration);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision avec : " + collision.gameObject.name);
        //invokeParticleEffect();
        Destroy(gameObject);
    }
}