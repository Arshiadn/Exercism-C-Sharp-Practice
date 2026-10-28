static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if(knightIsAwake)
            return false;
        return true;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(knightIsAwake || archerIsAwake || prisonerIsAwake)
            return true;
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(archerIsAwake && prisonerIsAwake)
            return false;
        else if(archerIsAwake == false && prisonerIsAwake == true)
            return true;
        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(knightIsAwake && archerIsAwake && petDogIsPresent){
            if(prisonerIsAwake)
                return false;
        }
        else if (knightIsAwake || archerIsAwake){
            if(petDogIsPresent && knightIsAwake){
                return true;
            }
            else if(prisonerIsAwake && petDogIsPresent)
                return false;
        }
        else if (prisonerIsAwake || petDogIsPresent){
            return true;
        }
        return false;
    }
}
