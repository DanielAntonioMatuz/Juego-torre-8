using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVidaScript : MonoBehaviour
{

    [Tooltip("Vida maxima del jugador")]
    public int VidaMaxima;

    private Image relleno;
    private int vidaActual;
    // Start is called before the first frame update
    void Start()
    {
        relleno = GetComponent<Image>();
        vidaActual = VidaMaxima;

        //Para probar

        vidaActual = 50;
        UpdateBarraVida();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool aplicarHerida(int herida) {
        // Aplica el daño a la vida actual
        vidaActual -= herida;

        // Si me queda vida, debo actualizar la vida actual
        if(vidaActual > 0) {
            UpdateBarraVida();
            return false;
        }

        vidaActual = 0;
        UpdateBarraVida();
        return true;
    }

    void UpdateBarraVida() {
        float porcentaje = vidaActual * 1.0f / VidaMaxima;

        // Aplica  el porcentaje al relleno de la barra de vida
        relleno.fillAmount = porcentaje;
    }
}
