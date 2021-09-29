using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{   
   [Header ("Health")] 
   [SerializeField] private float startingHealth;
   public float currentHealth{ get; private set; }
   private Animator anim;
   private bool dead;

   [Header ("iFrames")]
   [SerializeField] private float iFramesDuration;
   [SerializeField] private int numberOfFlashes;
   private SpriteRenderer spriteRend;

   private void Awake()
   {
       currentHealth = startingHealth;
       anim = GetComponent<Animator>();
       spriteRend = GetComponent<SpriteRenderer>();
   }
   public void TakeDamage(float _damage)
   {
       currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

       if (currentHealth > 0)
       {
           //player hurt
           anim.SetTrigger("hurt");
           //iframes
           StartCoroutine(Invunerabilty());
       }
       else
       {
           //player dead
            if(!dead)
            {
            anim.SetTrigger("die");
            GetComponent<PlayerMovement>().enabled = false;
            dead = true;
            }   
       }
   }
   private IEnumerator Invunerabilty()
   {
       Physics2D.IgnoreLayerCollision(8, 9, true);

       for(int i = 0; i < numberOfFlashes; i++)
       {
           spriteRend.color = new Color(1, 0, 0, 0.5f);
           yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
           spriteRend.color = Color.white;
           yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
       }
       Physics2D.IgnoreLayerCollision(8, 9, false);
   }

}
