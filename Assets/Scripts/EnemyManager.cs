using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{
    public NavMeshAgent enemy;
    public GameObject player;
    public PlayerManager mg;
    public float EnemyHealth = 20.0f;
    public Animator anim;
    void Start()
    {
        player.GetComponent<GameObject>();
        mg.GetComponent<PlayerManager>();
        anim.GetComponent<Animator>();
    }
    void LateUpdate()
    {
        enemy.destination = player.transform.position;
        anim.Play("Zombie Walking");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player") 
        {
            mg.Damage(20);
        }
    }
}
