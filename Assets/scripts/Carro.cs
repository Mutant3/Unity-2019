using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 carro;
    public Vector3 carro2;

    void Start()
    {
        carro = transform.position;
        carro2 = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CarroClick1(){
        if(carro.y == -0.2800002f){
        carro.y = -0.2800002f;
        transform.position = carro;
        }
        else{
            carro.y += +0.77f;
            transform.position = carro;
        }
    }

    public void CarroClick2(){
        if (carro2.y == -0.2400002f)
        {
            carro2.y = -0.2400002f;
            transform.position = carro2;
        }

        else
        {
            carro.y += +0.77f;
            transform.position = carro;
        }
    }

    public void ResetCarro()
    {
        carro.y = -4.13f;
        transform.position = carro;
    }

}
