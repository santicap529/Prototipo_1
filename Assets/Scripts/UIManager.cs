using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtTiempo;
    // Start is called before the first frame update
    void Start()
    {
      UpdateScore(0);
    }

    public void UpdateScore(int score)
    {
      txtScore.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
      txtTiempo.text = Time.time.ToString("F2");  
    }
}
