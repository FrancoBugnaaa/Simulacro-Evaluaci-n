using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    public float producto1;
    public float producto2;
    public float producto3;
    public float MontoTotal= 10000;
    float sobra;


    // Start is called before the first frame update
    void Start()
    {sobra= (10000 - producto1 -producto2 - producto3);
        if (producto1 + producto2 + producto3 >= MontoTotal){
            Debug.Log("Le faltan $" + sobra);

            }
        else if (producto1 + producto2 + producto3 < MontoTotal)
        {
            Debug.Log("Le sobarn $" + sobra);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
