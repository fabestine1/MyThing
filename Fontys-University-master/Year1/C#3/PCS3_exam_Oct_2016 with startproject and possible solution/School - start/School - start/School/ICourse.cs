namespace School
{
    public interface ICourse
    {
        void AddParticipant(int id, string name);
        int GetPricePerParticipant();
    }
}
