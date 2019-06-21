//This script was written by the Bailee gang

using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour
{
    public Transform target;
    public Transform start;
    public int maxHealth = 100;
    public int curHealth = 0;
    private NavMeshAgent nav;

    private void Start()
    {
        curHealth = maxHealth;
        nav = GetComponent<NavMeshAgent>();
        nav.SetDestination(target.position);
        gameObject.transform.position = start.transform.position;
    }

    private void Update()
    {
        if (this.gameObject.transform.position == target.transform.position)
        {
            gameObject.transform.position = start.transform.position;
        }
    }

    public void TakeDamage(int damage)
    {
        maxHealth -= damage;
        if (curHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
