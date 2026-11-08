class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    public int speed;
    public int batteryDrain;
    
    private int distanceDriven;
    private int battery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }
    
    public bool BatteryDrained()
    {
        if(battery >= batteryDrain)
            return false;
        return true;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (battery >= batteryDrain)
        {
            distanceDriven += speed;
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;    
    }
    
    public bool TryFinishTrack(RemoteControlCar car)
    {
        int driveCount = (int)Math.Ceiling((double)distance / car.speed);
    
        return driveCount * car.batteryDrain <= 100;
    }
}
