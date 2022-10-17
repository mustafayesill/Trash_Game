using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class atik_kutusu : MonoBehaviour
{
   /* public bool eslestiMi = false;
    
    [SerializeField] public List<atik> atik_prefabs;
    [SerializeField] public Transform atikParent, slotParent;

    /*public void OnTriggerEnter2D(Collider2D collision)
    {
        ProcessCollision(collision.gameObject);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        ProcessCollision(collision.gameObject);
    }
    public void ProcessCollision(GameObject collider)
    {
        eslestiMi = true;
        if (eslestiMi == true)
        {
            Debug.Log("1 nesne üretildi!");
            Respawn();
        }
        else
        {
            Debug.Log("Basarisiz!");
        }
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        ProcessCollision(collision.gameObject);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        ProcessCollision(collision.gameObject);
    }
    public void ProcessCollision(GameObject collider)
    {
        if (collider.CompareTag(tag))
        {
            eslestiMi = true;
            Debug.Log("dogru!");
            atik_prefabs.Clear();
            Respawn();


        }
        else
        {
            Debug.Log("Basarisiz!");
            eslestiMi = false;
            if (eslestiMi == false)
            {
                Debug.Log("yanlýþ");
            }

            
        }
    }
    public void Respawn()
    {
        var randomSet = atik_prefabs.OrderBy(s => Random.value).Take(1).ToList();
        for (int i = 0; i < randomSet.Count; i++)
        {
            var spawnedAtik = Instantiate(randomSet[i], atikParent.GetChild(i).position, Quaternion.identity);
        }
    }



    */

}
