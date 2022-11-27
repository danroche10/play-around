using System;

class Cow
{
    public event Action mooing;

    public void PushSleepingCow()
    {
        // .....
        if (mooing != null)
            mooing();
    }
}