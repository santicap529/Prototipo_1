using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionScript : MonoBehaviour
{

    void Awake()
    {
     
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
         GameManager.Instance.ItemRecolectado();
       }
    }

}
