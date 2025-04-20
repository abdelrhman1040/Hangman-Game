using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenAnimation : MonoBehaviour
{
    public float speed;
    public GameObject[] layers;
    public int layerNumber;
    float time;

    void Start()
    {

    }

    void Update()
    {
        time += Time.deltaTime;

        if (speed <= time)
        {
            if (layerNumber == layers.Length)
            {
                layerNumber = 0;
            }

            for (int i = 0; i < layers.Length; i++)
            {
                if (layerNumber == i)
                {
                    layers[i].SetActive(true);

                }
                else
                {
                    layers[i].SetActive(false);
                }
            }

            layerNumber++;
            time = 0;
        }
    } 
}
