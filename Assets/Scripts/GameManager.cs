using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   //El arreglo de waypoint son las posiciones en el mapa
    public Vector3[] waypoints;

// 11 de feb
//variable booleana para saber si el raton esta sobre la zona
//donde se puede poner las torres
    private bool _isPointerOnAllowed = true;
    //funcion que vuelve el valor  de la variable privada anterior
    public bool isPointerOnAllowed(){
        return _isPointerOnAllowed;
    }

    // se llama automaticamente cuando el raton dentro de uno
    //de los colaides del GameManager
    void OnMouseEnter(){
        _isPointerOnAllowed=true;

    }
    // se llama cuando el raton sale del colaider del GameManager
    void OnMouseExit(){
        _isPointerOnAllowed=false;
    }

}
