using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttack
{
    public int Damage {get; set;}

    public void Attack();
}
