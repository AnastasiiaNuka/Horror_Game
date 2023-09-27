using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIhunter : MonoBehaviour
{
    public NavMeshAgent ai;
    public Transform player;
    Vector3 dest; //назначение аи

    void Update()
    {
        dest = player.position;
        ai.destination = dest;
    }
}



