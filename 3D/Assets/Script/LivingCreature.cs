using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Rigidbody),typeof(Collider),typeof(Animator))]
[RequireComponent(typeof(NavMeshAgent))]

public class LivingCreature : MonoBehaviour
{

    public Rigidbody CreatureRB { get; private set; }
    public Collider CreatureCollider { get; private set; }
    public NavMeshAgent CreatureNavMeshAgent { get; private set; }
    public Animator CreatureAnimator { get; private set; }

   // [SerialezeField] private LivingCreatureActionController _actionController;
   // public LivingCreatureActionController => _actionController;
    // Start is called before the first frame update
    void Start()
    {
        CreatureRB = GetComponent<Rigidbody>();
        CreatureCollider = GetComponent<Collider>();
        CreatureNavMeshAgent = GetComponent<NavMeshAgent>();
        CreatureAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
