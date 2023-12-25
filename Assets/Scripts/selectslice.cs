using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;


public class selectslice : MonoBehaviour
{
    //8 slices
    public GameObject[] slices = new GameObject[8];
    //timer
    private float timer = 0.0f;
    //slice to select
    private int slice = 0;
    //next time to select
    public float next_time = 5.0f;

    private float cut_timer = 0.0f;
    public float cut_wait_time = 2.0f;

    public hand hand_;

    //public KnifeManager knife;

    private Dictionary<int, float> angles;

    private bool waiting = false;
    private bool cutting = false;

    private bool[] took = new bool[8];

    // Start is called before the first frame update
    void Start()
    {
        angles = new Dictionary<int, float>
        {
            { 0, 22.5f },
            { 1, 67.5f },
            { 2, 112.5f },
            { 3, 157.5f },
            { 4, 202.5f },
            { 5, 247.5f },
            { 6, 292.5f },
            { 7, 337.5f }
        };
        hand_.SetVisable(false);
        for(int i = 0; i < slices.Length; i++)
        {
            slices[slice].GetComponent<PizaaMove>().SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= next_time)
        {
            //select a random slice
            if (!waiting)
            {
                waiting = true;
                slice = Random.Range(0, 7);
                while (took[slice])
                {
                    slice = Random.Range(0, 7);
                }
                took[slice] = true;
                //rotate hand
                hand_.RotateHand(angles[slice]);
                //cut the slice
                //StartCoroutine(knife.MoveRepeatedly());
                //show hand
                hand_.SetVisable(true);
            }
            else
            {
                Cut();
            }
            if(timer >= next_time + cut_wait_time && !cutting)
            {
                //reset timer
                timer = 0.0f;
                waiting = false;
            }
        }
        //if last slice, load scene
        int count = 0;
        for(int i = 0; i < took.Length; i++)
        {
            if (took[i])
            {
                count++;
            }
        }

        if (count == 6)
        {
            SceneManager.LoadScene("ResultScene");
        }
    }

    private void Cut()
    {
        cutting = true;
        //wait for move
        cut_timer += Time.deltaTime;
        if(cut_timer >= cut_wait_time)
        {
            cutting = false;
            //hide hand
            hand_.SetVisable(false);
            //reset timer
            cut_timer = 0.0f;
            //move the slice away
            slices[slice].GetComponent<PizaaMove>().SetActive(true);

        }
    }
}
