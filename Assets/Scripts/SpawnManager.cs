using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] nuagePrefabs;
    // Variables limitant la position à la pateforme de jeu
    private float spawnRangeZ = -500;
    //private float spawnPosZ = 500;

    private float startDelay = 0.2f;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        // Appel la fonction personnalisé (nomFonction, Temps delais, L'interval d'apparition)
        InvokeRepeating("SpawnRandomNuage", startDelay, spawnInterval);

    }
    // Fonction Personnalisé
    void SpawnRandomNuage()
    {
        // Génère une position au hasard
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeZ, -spawnRangeZ), 100f, -300);

        // Génère un petit nuage au hasard (grace au SPAWNPOS il s'ajoute a la fonction d'en haut pour générer une 
        // Position au hasard)
        int nuageIndex = Random.Range(0, nuagePrefabs.Length);
        Instantiate(nuagePrefabs[nuageIndex], spawnPos, nuagePrefabs[nuageIndex].transform.rotation);
    }
}