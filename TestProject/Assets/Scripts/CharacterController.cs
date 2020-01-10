using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update

    public string name = "Nick";
    public int health = 200;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(name);
    }
}
