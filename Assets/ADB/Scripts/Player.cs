using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace ahndabi
{
    public class Player : MonoBehaviour
    {
        // �÷��̾ ������ �ִ� �͵�

        [SerializeField] protected Animator anim;
        [SerializeField] protected GameObject diePlayer;
        [SerializeField] protected Gun gun;
        [SerializeField] int hp;
        [SerializeField] public int Hp { get { return hp; } private set { if (hp <= 0) hp = 0; else hp = value; } }

        private void Awake()
        {
            anim = GetComponentInChildren<Animator>();
            gun = GetComponentInChildren<Gun>();
        }

        private void Start()
        {
            hp = 200;
        }

        protected int DecreaseHp(int damage)
        {
            hp -= damage;
            if (hp <= 0)
                hp = 0;
            return hp;
        }
    }
}