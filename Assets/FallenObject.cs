using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenObject : MonoBehaviour
{
    public ParticleSystem particle;
    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        Collider[] col = Physics.OverlapSphere(transform.position, 10);
        foreach (Collider c in col)
        {
            if (c.GetComponent<MyColliderHolder>() != null && c.GetComponent<MyColliderHolder>().GetComponentInParent<PlayerMovement>().gameObject != gameObject)
            {
                c.GetComponentInParent<PlayerMovement>().SendMessage("TakeDamage",Random.Range(14,24));
            }
        }
        audioSource.Play();
        particle.Play();
        Destroy(this.gameObject, particle.main.duration);
        
            
    }




}
