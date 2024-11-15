using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class SpeedRacer : MonoBehaviour
{
    public string carModel = "GroupTrack R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    public string carMaker;

    void Start()
    {
        print("The car model is " + carModel + ", the car maker is " + carMaker + " and the engine type is " + engineType + " .");
        CheckWeight();

        if(yearMade<=2009)
        {
            print("The car was introduced in " + yearMade + " .");
            int carAge = CalculateAge(yearMade);
            print("The car is " + carAge + " years old.");
        }
        else
        {
            print("The car was introduced in the 2010's.");
            print("The car's maximum acceleration is " + maxAcceleration + " .");
        }

        print(CheckCharacteristics());
    }

    void CheckWeight()
    {
        if(carWeight<1500)
        {
            print("The car " + carModel + " weighs less than 1500 kg.");
        }
        else
        {
            print("The car " + carModel + " weighs over 1500 kg.");
        }
    }

    int CalculateAge(int yearMade)
    {
        return 2023 - yearMade;
    }

    string CheckCharacteristics()
    {
        if(isCarTypeSedan)
        {
            return "The car type is sedan.";
        }
        else
        {
            if(hasFrontEngine)
            {
                return "The car isn't a sedan, but has a front engine.";
            }
            else
            {
                return "The car is neither a sedan nor does it have a front engine.";
            }
        }
    }

    public class Fuel
    {
        public int fuelLevel;

        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }

    public Fuel carFuel = new Fuel(100);

    void ConsumeFuel()
    {
        carFuel.fuelLevel -= 10;
    }
    void CheckFuelLevel()
    {
        switch(carFuel.fuelLevel)
        {
            case 70:
                print("fuel level is nearing two-thirds.");
                break;
            case 50:
                print("fuel level is at half amount.");
                break;
            case 10:
                print("Warning! Fuel level is critically low.");
                break;
            default:
                print("there's nothing to report");
                break;
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
    }
}
