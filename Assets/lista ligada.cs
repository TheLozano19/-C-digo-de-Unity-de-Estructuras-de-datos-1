using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class listaligada : MonoBehaviour
{
   
    public List<GameObject> Enemys = new List<GameObject>();
    public GameObject Enemy; 

    void Start()
    {
       
    }

    void Update()
    {
        
        if (Keyboard.current != null && Keyboard.current.qKey.wasPressedThisFrame)
        {
            SpawnEnemy();
        }

       
        if (Keyboard.current != null && Keyboard.current.wKey.wasPressedThisFrame)
        {
            KillEnemy();
        }
    }

    
    public void SpawnEnemy()
    {
        
        GameObject newEnemy = Instantiate(Enemy, transform.position, Quaternion.identity);


        Enemys.Add(newEnemy);

        Debug.Log("Enemigo spawneado" + Enemys.Count);
        Imprimewe();
    }

   
    public void KillEnemy()
    {
        if (Enemys.Count > 0)
        {
            GameObject enemyToRemove = Enemys[0];

            
            Destroy(enemyToRemove);

            
            Enemys.Remove(enemyToRemove);

            Debug.Log("El enemigo murió");
            Imprimewe();
        }
        else
        {
            Debug.Log("No hay enemigos");
        }
    }

    
    public void Imprimewe()
    {
        foreach (GameObject enemy in Enemys)
        {
            Debug.Log("Enemigos activo " + enemy.name);
        }
    }
}
