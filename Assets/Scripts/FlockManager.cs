using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockManager : MonoBehaviour
{
    //Criando um Singleton
    #region SINGLETON
    public static FlockManager instance;
    private void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }
    #endregion

    //Prefab do peixe, Array com todos os peixes da Scene.
    public GameObject fishPrefab;
    public GameObject[] allFish;

    //Num total de peixes a serem instanciados.
    public int numFish = 20;

    //Vector3 que será utilizado para calcular o futuro Spawn dos peixes.
    public Vector3 swinLimits = new Vector3(5, 5, 5);

    //Velocidade
    public float minSpeed, maxSpeed;

    private void Start()
    {
        //Set qnt de peixes na Scene
        allFish = new GameObject[numFish];

        //Instanciando os peixes
        for (int i = 0; i < numFish; i++)
        {
            //Setando Posicoes RANDOM
            Vector3 pos = this.transform.position + new Vector3(Random.Range(-swinLimits.x, swinLimits.x),
                                                                Random.Range(-swinLimits.y, swinLimits.y),
                                                                Random.Range(-swinLimits.z, swinLimits.z));
            //Instanciando os peixes nas posições RANDOM de cima (:
            allFish[i] = (GameObject)Instantiate(fishPrefab, pos, Quaternion.identity);
        }
    }
}
