using System;
using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

[SerializeField]
public interface IEnemy
{
    void Die();
    void RemoveHp(int damage);
    bool CheckPos(Vector3 mousePos);
}
