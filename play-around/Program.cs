class MainClass
{
    static void Main()
    {
        TrainSignal trainSignal = new TrainSignal();
        new Car(trainSignal);
        new Car(trainSignal);
        new Car(trainSignal);
        new Car(trainSignal);
        trainSignal.TrainsAComing();
        trainSignal.TrainsAComing();
        trainSignal.TrainsAComing();
        trainSignal.TrainsAComing();
        trainSignal.TrainsAComing = null;
        trainSignal.HereComesATrain();
    }
}