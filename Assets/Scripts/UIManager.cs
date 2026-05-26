using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI txtTiempo;

    public GameObject Panel_Ganaste;
    public GameObject Panel_gameover;

    void Start()
    {
        Panel_Ganaste.SetActive(false);
        Panel_gameover.SetActive(false);
    }

    void Update()
    {
        if (GameManager.Instance != null)
            txtTiempo.text = GameManager.Instance.tiempoRestante.ToString("F2");
    }

    public void UpdateScore(int score)
    {
        txtScore.text = score.ToString();
    }

    public void MostrarPantallaWin()
    {
        Panel_Ganaste.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        Panel_gameover.SetActive(true);
    }
}