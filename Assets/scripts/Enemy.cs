using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyState{
    idle,
    walk,
    attack,
    stagger
}
public class Enemy : MonoBehaviour
{

    public EnemyState currentState;
public int health;
public string enemyName;
public int baseAttack;
public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Knock(Rigidbody2D myRigdbody2D, float koncktime)
    {
        StartCoroutine(KnockCO(myRigdbody2D, koncktime));
    }
    private IEnumerator KnockCO(Rigidbody2D myRigdbody2D, float koncktime)
    {
        if (myRigdbody2D != null )
        {
            myRigdbody2D.GetComponent<Enemy>().currentState = EnemyState.stagger;
            yield return new WaitForSeconds(koncktime);
            myRigdbody2D.velocity = Vector2.zero;
            currentState = EnemyState.idle;
            myRigdbody2D.velocity = Vector2.zero;

        }
    }
}
