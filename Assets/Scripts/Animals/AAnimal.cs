using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class AAnimal
{
    public enum Species { Fox, Bear };

    public float aggression = .5f;
    public float hunger = 0f;
    public float thirst = 0f;
    public float sleepyness = 0f;
    public bool sleeping = false;

    void FallAsleep()
    {

    }

    void WakeUp()
    {

    }

}
