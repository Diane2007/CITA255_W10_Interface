using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: IAttack
{
    public int Damage { get; set; }
    
    public void Attack()
    {
        Damage = 2;
        
        Debug.Log("Player damage " + Damage);
    }
    
    //camel case: someName
    //pascal case: SomeName
    //snake case: some_name
    
    /*
    int playerHp;
    public int PlayerHp
    {
        get { return playerHp; }
        set { playerHp = value; }
    }
    
    //string playerName;
    public string PlayerName { get; set; }
    */
    
    
}
