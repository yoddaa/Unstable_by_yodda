using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A grenade
// - instantiates an explosion Prefab when hitting a surface
// - then destroys itself

public class grenade : MonoBehaviour
{
    public int score;
    public Transform explosionPrefab;
    public Transform pointsPrefab;
    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            ContactPoint contact = collision.contacts[0];
            Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 position = contact.point;
            Instantiate(explosionPrefab, position, rotation);
            Destroy(gameObject);
        }
        if (collision.collider.CompareTag("Player"))
        {
            ContactPoint contact = collision.contacts[0];
            Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 position = contact.point;
            Instantiate(pointsPrefab, position, rotation);
            score++;
           
            Destroy(gameObject);
        }
    }
}
