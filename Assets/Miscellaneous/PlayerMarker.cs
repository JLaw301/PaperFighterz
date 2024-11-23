using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMarker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.GetComponentInParent<BaseCharacter>().playerType == "Player1"){
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else{
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 216, 230, 255);
        }
    }
}