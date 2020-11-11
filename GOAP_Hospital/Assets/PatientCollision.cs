using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatientCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Patient")
        {
            DialogueManager.scc.setGameStateValue("collision", "equals", "t");
            Debug.Log(DialogueManager.scc.getSCCLine("Patient"));
        }
    }
}
