using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningHeart : PowerUp
{
    public FloatValue playerHealth;
    public FloatValue heartContainers;
    public float amountToIncrease;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void OnTriggerEnter2D(Collider2D other) {
       if (other.CompareTag("Player") && other.isTrigger) {
        playerHealth.runtimeValue += amountToIncrease;
        if (playerHealth.initialValue > heartContainers.runtimeValue * 2f) {
            playerHealth.initialValue = heartContainers.runtimeValue * 2f;
        }
        powerupSignal.Raise();
        Destroy(this.gameObject);
       }
    }
}
