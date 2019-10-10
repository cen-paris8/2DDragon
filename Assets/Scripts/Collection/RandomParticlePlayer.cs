using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomParticlePlayer : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] _possibleParticle;

    public void PlayRandomPosition(Vector3 Position)
    {
        int index = Random.Range(0, _possibleParticle.Length);

        _possibleParticle[index].transform.SetPositionAndRotation(Position, Quaternion.identity);
        _possibleParticle[index].Play();

    }
}

// ARRAY
// LIST EnnemyManager
// HASHSET SpammyTrigger Liste sans doublon, item unique
// DICTIONARY 1 ItemRepository // Id unique
// DICTIONARY 2 SelectionCounter // Id unique (objet) Ressemble à un Compteur
// QUEUE/STACK InventorySystem // Empile et Dépile des objets
