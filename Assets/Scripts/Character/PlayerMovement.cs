using NutriQuest.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour, IMove, IJump
{
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move()
    {
        Debug.Log("I Move");
    }

    public void Jump()
    {
        Debug.Log("I Jump");
    }

}
