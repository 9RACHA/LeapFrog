using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rana : MonoBehaviour {
	/*
    private Animator animator;
    //Numero total de veces que la rana ha atravesado el río
    private int trialCount;
    //Número total de saltos empleados para completar las veces
    //que se ha atravesado el río
    private int totalJumpCount;

    //Número de saltos que se han usado hasta el momento
    //en el ensayo actual
    private int currentTrialJumpCount;

    // Start is called before the first frame update

    private float jumpHeight = 2.0f;

    private float speed = 5.0f;

    private bool goingUp = false;
    private bool goingDown = false;

    private Vector2 jumpStartingPoint;
    private Vector2 jumpCentralPoint;
    private Vector2 jumpFinalPoint;


    //valor normalizado utilizado para la interpolación
    //en el movimiento de salto.
    private float t = 0.0F;

    //Tiempo calculado para cada fase del salto (para cada mitad)
    //se utiliza para normalizar el valor de t
    private float T;
    private int stepIndex;
    void Start() {
        stepIndex = -1;
        trialCount = 0;
        totalJumpCount = 0;
        currentTrialJumpCount = 0;

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        if(goingUp ) {
            t += Time.deltaTime / T;

            Vector2 newPosition = Vector2.Lerp(jumpStartingPoint, jumpCentralPoint, t);
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
            if(t >= 1) {
                t = 0;
                goingUp = false;
                goingDown = true;

                animator.SetBool("Jump", false);
                animator.SetBool("Fall", true);
            }
        } else if(goingDown) {
            t += Time.deltaTime / T;
            Vector2 newPosition = Vector2.Lerp(jumpCentralPoint, jumpFinalPoint, t);
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
            if(t >= 1) {
                t = 0;
                goingUp = false;
                goingDown = false;

                animator.SetBool("Jump", false);
                animator.SetBool("Fall", false);
                transform.position = jumpFinalPoint;
           }
        } else if(Input.GetKeyDown(KeyCode.Space)) {
            int stepNumber = GameManager.instance.StepNumber(); 

            if(stepIndex == stepNumber - 1) {
                stepIndex = -1;
                totalJumpCount += currentTrialJumpCount;
                trialCount++;
                currentTrialJumpCount = 0;
                transform.position = new Vector3(GameManager.instance.CalculateX(stepIndex), transform.position.y, transform.position.z);
            } else {
                stepIndex = Random.Range(stepIndex + 1, stepNumber);
                currentTrialJumpCount++;
                MoveFrog(stepIndex);
            } 

            Debug.Log("Numero de saltos total" + totalJumpCount);
            Debug.Log("Numero de ensayos completados" + trialCount);
            if(trialCount > 0) {
                Debug.Log("Media " + totalJumpCount / (float) trialCount);
            }
            Debug.Log("Numero de saltos del ensayo actual " + currentTrialJumpCount);


        } 

        GameManager.instance.UpdateResults(currentTrialJumpCount, totalJumpCount, trialCount);

    }

    private void MoveFrog(int stepIndex) {
        jumpStartingPoint = new Vector2(transform.position.x, transform.position.y);
        jumpFinalPoint = new Vector2(GameManager.instance.CalculateX(stepIndex), transform.position.y);
        jumpCentralPoint = new Vector2((jumpStartingPoint.x+jumpFinalPoint.x)/2 , transform.position.y+jumpHeight);

        T = (jumpCentralPoint - jumpStartingPoint).magnitude / speed;

        goingUp = true;
        animator.SetBool("Jump", true);
        animator.SetBool("Fall", false);
    }
	
	*/
 
}
