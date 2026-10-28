class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeekCount = {0, 2, 5, 3, 7, 8, 4};

        return lastWeekCount;
    }

    public int Today()
    {
        int lastIndex = birdsPerDay.Length - 1;

        return birdsPerDay[lastIndex];
    }

    public void IncrementTodaysCount()
    {
        int lastIndex = birdsPerDay.Length - 1;
        birdsPerDay[lastIndex] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach(int bird in birdsPerDay){
            if(bird == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;

        for(int i = 0; i < numberOfDays; i++){
            count += birdsPerDay[i];
        }
        return count;
    }

    public int BusyDays()
    {
        int count = 0;

        for(int i = 0; i < birdsPerDay.Length; i++){
            if(birdsPerDay[i] > 4)
                count ++;
        }
        return count;
    }
}
