using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;
//using UnityEngine.UI;
// A grenade
// - instantiates an explosion Prefab when hitting a surface
// - then destroys itself

public class grenade : MonoBehaviour
{
    public int score;
    public Transform explosionPrefab;
    public Transform pointsPrefab;
    //public TMP_Text textMP;

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
            //textMP.text = score.ToString();
            Destroy(gameObject);
        }
    }
}
