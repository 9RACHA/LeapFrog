using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    private int stepCount = 10; // Número de pasos en el juego
    private float stepDistance = 1.8f; // Distancia entre cada paso

    private float stepCoordY = -2; // Coordenada Y en la que se generan los pasos
    private float frogVerticalOffset = 0.5f; // Desplazamiento vertical del personaje "Frog" con respecto a los pasos

    public GameObject stepPrefab; // Prefab del paso
    public GameObject frogPrefab; // Prefab del personaje "Frog"

    private GameObject frog; // Referencia al objeto del personaje "Frog"

    void Awake() {
        instance = this;
    }

    void Start() {
        SpawnSteps(); // Generar los pasos en el juego
        SpawnFrog(); // Aparecer el personaje "Frog"
    }

    // Generar los pasos en el juego
    private void SpawnSteps() {
        for (int i = 0; i < stepCount; i++) {
            float x = CalculateX(i); // Calcular la posición X del paso actual
            Instantiate(stepPrefab, new Vector3(x, stepCoordY, 0), Quaternion.identity); // Instanciar el prefab del paso en la posición calculada
        }
    }

    // Aparecer el personaje "Frog"
    private void SpawnFrog() {
        frog = Instantiate(frogPrefab, new Vector3(CalculateX(-1), stepCoordY + frogVerticalOffset, 0), Quaternion.identity); // Instanciar el prefab del personaje "Frog" en la posición inicial
        // frog.GetComponent<Frog>().master = this; // Asignar una referencia al objeto "GameManager" en el script del personaje "Frog"
    }

    // Calcular la posición X de un paso dado su índice
    public float CalculateX(int position) {
        float oddEvenCorrection = 0;
        if (stepCount % 2 == 0) {
            oddEvenCorrection = stepDistance / 2; // Corrección para ajustar la posición de los pasos en caso de tener un número par de pasos
        }

        return stepDistance * (position - stepCount / 2) + oddEvenCorrection; // Calcular la posición X basada en la distancia y el índice del paso
    }
}

