using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour
{
    public GameObject centerAnchor;

    public GameObject hand_;

    private MeshRenderer meshRenderer;

    //angle around center anchor
    public float hand_angle;

    public float next_hand_angle;

    // Start is called before the first frame update
    void Start()
    {
        //set initial hand angle
        hand_angle = 0.0f;
        next_hand_angle = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        /*if(hand_angle!=next_hand_angle)
        {
            //rotate hand around center anchor
            hand_.transform.RotateAround(centerAnchor.transform.position, Vector3.up, (next_hand_angle - hand_angle) * Time.deltaTime);
            //gradually rotate hand to next angle
            hand_angle = Mathf.Lerp(hand_angle, next_hand_angle, 0.1f);
        }*/
    }

    private void FixedUpdate()
    {
        if ((int)hand_angle != (int)next_hand_angle)
        {
            float rotate_amount = next_hand_angle - hand_angle;
            //rotate hand around center anchor
            hand_.transform.RotateAround(centerAnchor.transform.position, Vector3.up, rotate_amount);
            //gradually rotate hand to next angle
            hand_angle = next_hand_angle;
        }
    }

    public void RotateHand(float angle)
    {
        next_hand_angle = angle;
    }

    public void SetVisable(bool visable)
    {
        hand_.SetActive(visable);
    }
}