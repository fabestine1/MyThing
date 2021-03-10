namespace MediaBazar
{
    class DepartmentComboBoxItem
    {
        string name;

        public DepartmentComboBoxItem(Department d)
        {
            name = d.Name;
            Id = d.DepartmentId;
        }

        public int Id { get; }

        //Override ToString method
        public override string ToString()
        {
            return name;
        }
    }
}
