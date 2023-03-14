using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager instance;

    private int stepCount = 10;
    private float stepDistance = 1.8f;
    
    private float stepCoordY = -2;
    private float frogVerticalOffset = 0.5f;

    public GameObject stepPrefab;

    public GameObject frogPrefab;

    private GameObject frog;


    void Awake() {
        instance = this;
    }

    void Start() {
        SpawnSteps();
        SpawnFrog();
    }

    private void SpawnSteps() {

        for(int i = 0; i < stepCount; i++ ) {
            float x = CalculateX(i);
            Instantiate(stepPrefab, new Vector3(x, stepCoordY, 0), Quaternion.identity);
        }

    }

    private void SpawnFrog() {
        frog = Instantiate(frogPrefab, new Vector3(CalculateX(-1), stepCoordY + frogVerticalOffset, 0), Quaternion.identity);
        //rana.GetComponent<Rana>().master = this;
    }

    public float CalculateX(int position) {
        float oddEvenCorrection = 0;
        if(stepCount % 2 == 0) {
            oddEvenCorrection = stepDistance / 2;
        }

        return stepDistance * (position - stepCount/2) + oddEvenCorrection;
    }
  
}
