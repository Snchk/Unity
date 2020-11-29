using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPicker : MonoBehaviour
{
    [SerializeField] private int _healvalue;

    private void OnTriggerEnter2D(Collider2D info)
    {
        info.GetComponent<Player_controller>().RestoreHP(_healvalue);
       Destroy(gameObject);
    }
    // Start is called before the first frame update
   
}
