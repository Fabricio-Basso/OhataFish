using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flock : MonoBehaviour
{    
    //Velocidade do peixe
    float speed;

    private void Start()
    {
        //Puxando speed diretamente do FlockManager através de um SINGLETON!! =D
        speed = Random.Range(FlockManager.instance.minSpeed, FlockManager.instance.maxSpeed);
    }

    private void Update()
    {
        //Movimentação do peixe
        transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
