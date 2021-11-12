using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float Health = 100.0f;
    public void Damage(float damage)
    {
        Health = Health - damage;
    }
}
