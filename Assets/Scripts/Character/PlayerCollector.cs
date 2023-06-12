using NutriQuest.Interfaces;
using UnityEngine;

public class PlayerCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
   
        Debug.Log("OnTriggerEnter");
        if (other.gameObject.CompareTag("Collectible"))
        {
            ICollectible collect = other.gameObject.GetComponent<ICollectible>();
            if (collect != null)
            {
                collect.OnCollect(gameObject);
            }
            
        }
    }
}
