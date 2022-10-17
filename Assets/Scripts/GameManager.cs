using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public List<atik> atik_prefabs;
    [SerializeField] public Transform atikParent, slotParent;
    
    public void Start()
    {
        spawn();
    }
    public void spawn()
    {
        var randomSet = atik_prefabs.OrderBy(s => Random.value).Take(1).ToList();
        for (int i = 0; i < randomSet.Count; i++)
        {
            var spawnedAtik = Instantiate(randomSet[i],atikParent.GetChild(i).position,Quaternion.identity);     
        }
    }

   
}
