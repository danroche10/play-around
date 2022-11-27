using System;

class TrainSignal
{
    public event Action TrainsAComing;
    public void HereComesATrain()
    {
        // there is a ron of logic here
        if (TrainsAComing != null)
            TrainsAComing();
    }
}

class Car
{
    public Car(TrainSignal trainSignal)
    {
        trainSignal.TrainsAComing += StopTheCar;
    }
    void StopTheCar()
    {
        Console.WriteLine("Screeeetch");
    }
}