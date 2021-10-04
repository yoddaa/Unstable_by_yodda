using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{
    // need to conect a plus to add to the points
    public TMP_Text textMP,scoreP;
    public int score;
   
    // Start is called before the first frame update
    void Start()
    {
        textMP.text = score.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.collider.CompareTag("NPC"))
        {
          
            score++;
           
            textMP.text = score.ToString();
            scoreP.text = score.ToString();
            // Destroy(gameObject);
        }
}
    
}
