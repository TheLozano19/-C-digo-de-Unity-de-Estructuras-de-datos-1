using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.tvOS;

public class Array_fijo : MonoBehaviour
{
    [System.Serializable]
    public class Item
    {
        public string nombre;

        public Item(string nombreItem)
        {
            nombre = nombreItem;
        }
    }
    public Item[] inventario = new Item[5];


    void Start()
    {
       

        
    }

    // Update is called once per frame
    void Update()
    {
        Item calabera = new Item("Craneo del tio Alfonso");
        Item machete = new Item("Machete del abuelo");
        Item pollo = new Item("Pollo robado de mi amiguita Catia");
        Item elote = new Item("Elote preparado con todo");
        Item bacardi = new Item("Botella de Bacardi por si se me atraviesa una rola de Jose Jose");
        if (Keyboard.current != null && Keyboard.current.f1Key.wasPressedThisFrame)
        {
            asignaItem(2, bacardi);
            asignaItem(3, elote);
            asignaItem(4, pollo);
            asignaItem(0, machete);
            asignaItem(1, calabera);
            asignaItem(6, calabera);
        }
        if (Keyboard.current != null && Keyboard.current.f2Key.wasPressedThisFrame)
        {
            verInventario(1);
            verInventario(2);
            verInventario(3);
            verInventario(4);
            verInventario(0);
            
        }
        if (Keyboard.current != null && Keyboard.current.f3Key.wasPressedThisFrame)
        {
            tirarInventario(2);
        }






    }

    public void asignaItem(int Indice, Item itemNuevo)
    {
        if (Indice >= 0 && Indice < inventario.Length)
        {
            inventario[Indice] = itemNuevo;
            if (itemNuevo != null)
            {
                Debug.Log($"O mira lo que encontre'{itemNuevo.nombre}'me lo llevo, va en la bolas{Indice} recuerdame");
            }
            else
            {
                Debug.Log($"No pues lo que tenia en la bolsa {Indice} ya me lo acabe ");
            }
           
        }
        else
        {
            Debug.LogError($"No pues {Indice} ya no entro, a esto solo le entra {inventario.Length}.");
        }
    }
    void verInventario(int Indice)
    {
        if (Indice >= 0 && Indice < inventario.Length)
        {
            if (inventario[Indice] != null)
            {
                Debug.Log($" A ver en la bolsa{Indice}tengo {inventario[Indice].nombre} solo por si acaso ");
            }
            else if(inventario[Indice] == null)
            {
                Debug.Log($"No pues en la bolsa{Indice} no tengo nada");
            }
        }
        else
        {
            Debug.LogError($"La bolsa {Indice} ni existe");
        }
    }

    
    void tirarInventario(int Indice)
    {
        if (Indice >= 0 && Indice < inventario.Length)
        {
            if (inventario[Indice] != null)
            {
                Debug.Log($"Deja saco las cosas de la bolsa {Indice} ni modo {inventario[Indice].nombre} algun dia regresare por ti");
                inventario[Indice] = null;
            }
            else if (inventario[Indice] == null)
            {
                Debug.Log($"No pues en la bolsa {Indice} ya no tenia nada.");
            }
        }
        else
        {
            Debug.LogError($"No pues la bolsa {Indice} ni siquiera eiste .");
        }
    }
}
