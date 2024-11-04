using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string PlayerName;
    public int health;
    //لهان تمام
    public int maxHealth = 100; //اقصى قيمة للهيلث
    static public int playerCount;
    public void InitializePlayer(string name, int initialHealth)
    {
        PlayerName = name;
        health = initialHealth;
        playerCount++; 
        Debug.Log($"[Player Initialized] Player Name: {PlayerName}, Health: {health}");

    }

    public void Heal(int amount)
    {
      //  health += amount;
        if (health > maxHealth)
        {
           health = maxHealth;
        }
        //Debug.Log(PlayerName + " healed by " + amount + " new health " + health);
        Debug.Log($"[PlayerHealed] {PlayerName} health by {amount}. New Health: {health}");

    }
    public void Heal(bool fullRestore)
    {
        if (fullRestore == true)
        {
            health = maxHealth;
            Debug.Log($"[FullRestore] {PlayerName} health is full restored. New Health: {health}");

        }
        else
        {
            health++;
        }
    }
    static public void ShowPlayerCount()
    {
        Debug.Log($"[Player Count] Total Players: {playerCount}");
    }
}