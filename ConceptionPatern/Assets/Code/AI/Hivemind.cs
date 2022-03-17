using System;
using System.Collections.Generic;
using UnityEngine;

public class Hivemind : MonoBehaviour
{
    public GameObject[] unitsInScene;

    public int flockMaxSize;
    
    public List<Flock> flocks;
    public HivemindState hivemindState;
    public enum HivemindState{STATIONNARY, MOVING, FIGHTING, FLEEING}

    [Serializable] public class Flock
    {
        public int flockID;
        private float flockEffectRange;
        public float effectRangeMultiplier;
        public GameObject[] units;
        public List<SubFlock> subFlocks;
        
        [Serializable] public struct SubFlock
        {
            public string subFlockType;
            public List<GameObject> unitsInThisSubFlock;
        }
    }

    private void InitializeFlock()
    {
         
    }

    private void Awake()
    {
        unitsInScene = GameObject.FindGameObjectsWithTag("Allies");
    }

    private void Start()
    {
        CreateFlock(unitsInScene);
    }

    public void DebugCreateFlock()
    {
        CreateFlock(unitsInScene);
    }


    public void CreateFlock(GameObject[] units)
    {
        Flock newFlock = new Flock();
        
            flocks.Add(newFlock);
            newFlock.units = units;
            newFlock.flockID = flocks.Count -1;

            foreach (var newUnit in units)
            {
                var unitBrain = newUnit.GetComponent<UnitBrain>();
                unitBrain.flockAssign = newFlock.flockID;
            }

    }

    private void SetSubUnits()
    {
        foreach (var f in flocks)
        {
            foreach (var sf in f.subFlocks)
            {
                
            }
        }
    }

    public void FuseFlock(GameObject flockA, GameObject flockB)
    {
        
    }
    
    
}
