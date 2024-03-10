using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * DESCRIPTION
 *      Project Based on Course/Project 1: https://www.udemy.com/course/unitycourse2/
 *      It's a Simple dodge obstacles game
 *      This Script controls the PLAYER
 *
 * DATE
 *      Start: 02/27/2024
 *     
 * PACKAGES:
 *      Cinemachine Camera
 *      
 */

public class Mover : MonoBehaviour
{
    float xValue, yValue, zValue;
    [SerializeField] float speedSensibility = 0.2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        // frame independent Player Control (WASD)
        xValue = Input.GetAxis("Horizontal") * speedSensibility;
        zValue = Input.GetAxis("Vertical") * speedSensibility;
        transform.Translate(xValue, yValue, zValue);
    }


}