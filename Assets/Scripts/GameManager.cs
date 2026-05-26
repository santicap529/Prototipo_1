using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int scoreActual = 0;
    public int scoreMaximo = 3;
    public float tiempoRestante = 15f;

    private bool juegoTerminado = false;

    private UIManager uiManager;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        Time.timeScale = 1;
    }

    void Start()
    {
        uiManager = GameObject.FindObjectOfType<UIManager>();
        uiManager.UpdateScore(scoreActual);
    }

    void Update()
    {
        if (juegoTerminado)
        {
            // Sistema de reinicio con R
            if (Input.GetKeyDown(KeyCode.R))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            return;
        }

        tiempoRestante -= Time.deltaTime;

        if (tiempoRestante <= 0f)
        {
            tiempoRestante = 0f;
            TerminarJuego(false);
        }
    }

    public void ItemRecolectado()
    {
        if (juegoTerminado) return;

        scoreActual++;
        uiManager.UpdateScore(scoreActual);

        if (scoreActual >= scoreMaximo)
            TerminarJuego(true);
    }

    void TerminarJuego(bool gano)
    {
        juegoTerminado = true;
        Time.timeScale = 0;

        if (gano)
        {
            Debug.Log("Ganaste");
            uiManager.MostrarPantallaWin();
        }
        else
        {
            Debug.Log("Perdiste");
            uiManager.MostrarPantallaGameOver();
        }
    }
}
