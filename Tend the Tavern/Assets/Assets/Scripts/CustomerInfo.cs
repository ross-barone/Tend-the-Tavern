using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerInfo : MonoBehaviour
{
    //The current state the customer is in
    public enum state
    {
        Waiting, 
        Seated, 
        Ordered, 
        Eating, 
        Paying
    }
    [SerializeField] public state currentState = state.Waiting;

    //The amount of patience the customer has left
    [SerializeField] float patience = 100;

    //If the customer has been chatted with
    [SerializeField] bool hasChatted = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Calls the needed method based on the current state
        switch (currentState)
        {
            case state.Waiting:
            default:
                whileWaiting();
                break;
            case state.Seated:
                whileSeated();
                break;
            case state.Ordered:
                whileOrdered();
                break;
            case state.Eating: 
                whileEating();
                break;
            case state.Paying: 
                whilePaying();
                break;
        }

        if (patience <= 0)
        {
            //TODO: customer leaves
            Debug.Log("A customer has left!");
        }
    }

    /// <summary>
    /// Called every frame when customer is Waiting
    /// </summary>
    void whileWaiting()
    {
        patience -= Time.deltaTime * .1f;

        //TODO: if empty seat is found, switch to seated and add 50 patience
    }

    /// <summary>
    /// Called every frame when customer is Seated
    /// </summary>
    void whileSeated()
    {
        patience -= Time.deltaTime * .2f;

        //TODO: if customer is spoken to, switch to ordered and add 50 patience
    }

    /// <summary>
    /// Called every frame when customer has ordered
    /// </summary>
    void whileOrdered()
    {
        //TODO: if food arrives, switch to eating
        //TODO: if customer is spoken to, switch hasChatted to true
    }

    /// <summary>
    /// Called ever frame when customer is eating
    /// </summary>
    void whileEating()
    {
        //How long the customer takes to eat is random
        float eatTime = Random.Range(5, 7);

        eatTime -= Time.deltaTime;

        if (eatTime <= 0)
        {
            currentState = state.Paying;

            //TODO: customer creates messy dishes at their seat
        }
    }

    void whilePaying()
    {
        //TODO: if interacted with, customer will leave.
    }
}
