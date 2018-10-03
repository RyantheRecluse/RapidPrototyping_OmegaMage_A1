using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
    void Start()
    {

    }

	void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameEvents.ReportOnScoreChange(100);
            Destroy(this.gameObject);
        }
    }
}
