using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionScript : MonoBehaviour
{
    public int score;
    public UIManager UIMgrScript;

    void Awake()
    {
     UIMgrScript = GameObject.FindObjectOfType<UIManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Colectable"))
       {
         Destroy(other.gameObject);
         UIMgrScript.UpdateScore(score);
       score ++;
       }
    }

}
