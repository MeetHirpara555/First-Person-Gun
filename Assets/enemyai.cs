using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Utility;

public class enemyai : MonoBehaviour
{
    NavMeshAgent agent;
    Transform player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        agent.SetDestination(player.position);
        
    }
    
}
