using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject enemy;
    private float Delay = 2.0f;
    public Vector2 delayRange = new Vector2(1, 2);
    public EnemyManager em;
    void Start()
    {
        StartCoroutine(Generator());
    }

    IEnumerator Generator()
    {
        yield return new WaitForSeconds(Delay);
        GameObject ob = Instantiate(enemy);

        StartCoroutine(Generator());
    }
    void ResetDelay()
    {
        Delay = Random.Range(delayRange.x, delayRange.y);
    }
}
