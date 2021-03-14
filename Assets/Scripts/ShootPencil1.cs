using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPencil1 : MonoBehaviour
{
    private float Ypos1 = 1.5f;
    private float Ypos2 = 3f;
    private float randomTime1 = 0.5f;
    private float randomTime2 = 2f;
    public GameObject[] Prefab;

    void Start()
    {
        float RandomShooting = Random.Range(randomTime1, randomTime2);
        InvokeRepeating("PencilProjectile", 2.0f, RandomShooting);
        InvokeRepeating("PencilProjectile2", 2.0f, RandomShooting);
        InvokeRepeating("PencilProjectile3", 2.0f, RandomShooting);
    }


    void PencilProjectile()
    {
        // shoots pencils at random hights ranging from 1.5 to 3
        float randYPos = Random.Range(Ypos1, Ypos2);
        int PencilIndex = Random.Range(0, Prefab.Length);
        Vector3 ShootPos = new Vector3(-78, randYPos, -13);


        // spawns the pencils in the designated spots

        Instantiate(Prefab[PencilIndex], ShootPos,
            Prefab[PencilIndex].transform.rotation);
    }

    void PencilProjectile2()
    {
        float randYPos = Random.Range(Ypos1, Ypos2);
        int PencilIndex = Random.Range(0, Prefab.Length);
        Vector3 ShootPos2 = new Vector3(-133, randYPos, -13);
        Instantiate(Prefab[PencilIndex], ShootPos2,
            Prefab[PencilIndex].transform.rotation);
    }

    void PencilProjectile3()
    {
        float randYPos = Random.Range(Ypos1, Ypos2);
        int PencilIndex = Random.Range(0, Prefab.Length);
        Vector3 ShootPos3 = new Vector3(-176, randYPos, -13);
        Instantiate(Prefab[PencilIndex], ShootPos3,
            Prefab[PencilIndex].transform.rotation);
    }

}
