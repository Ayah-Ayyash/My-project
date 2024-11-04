using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player p1 = new Player();
        Player p2 = new Player();
        p1.InitializePlayer("Ayah", 70);
        p2.InitializePlayer("Hosam", 100);
        //بعدين بدي استدعي الشو بلاير كاونت
        p1.Heal(70);
        p2.Heal(true);
        Player.ShowPlayerCount();

    }
}
