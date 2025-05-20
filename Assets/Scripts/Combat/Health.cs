using System;
using UnityEngine;

namespace RPG.Combat
{
    public class Health : MonoBehaviour
    {
        [SerializeField] float health = 100f;
        bool isDead;
        Animator animator;

        void Start()
        {
            animator = GetComponent<Animator>();
        }

        public bool IsDead()
        {
            return isDead;
        }

        public void TakeDamage(float damage)
        {
            health = Mathf.Max(health - damage, 0);
            Debug.Log(health);
            if (health == 0) Die();
        }

        private void Die()
        {
            if (isDead) return;

            isDead = true;
            animator.SetTrigger("dead");
        }
    }
}