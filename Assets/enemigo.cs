using UnityEngine;
using System.Collections.Generic;
public class enemigo : MonoBehaviour
{
    List<GameObject> Enemys = new List<GameObject>();
    public GameObject Enemy;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Lista();
        
    }
    
   /* public void Lista()
    {
        
        // 2. Agregar elementos (la lista crece dinámicamente)
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Enemys.Add("Enemy");
        }
        
       
      
        Debug.Log("Elementos en la lista:");
        foreach (string fruta in Enemys)
        {
            Debug.Log($"- {Enemys}");
        }

        // 4. Eliminar un elemento
        Enemys.Remove("Enemy");

       
    }*/
}

