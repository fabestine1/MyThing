namespace StudyAdvisor
{
    using System.Linq;
    using System.Collections.Generic;
    
    public enum Recommendation
    {
        POSITIVE,
        CONDITIONAL_POSITIVE,
        CONDITIONAL_NEGATIVE,
        NEGATIVE
    }

    public class Student
    {
        private string name;
        private int number;
        private List<Module> modules;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public Student(string name, int number)
        {
            this.name = name;
            this.number = number;
            this.modules = new List<Module>();
        }

        public Module AddModule(string code, int ec, int exammark, bool passedPractical)
        {
            Module module = new Module(code, ec, exammark, passedPractical);
            modules.Add(module);
            return module;
        }

        public void RemoveModule(int index)
        {
            modules.RemoveAt(index);
        }

        public int GetAchievedEC()
        {
            int sum = 0;

            foreach (var module in modules)
            {
                sum += module.GetAchievedEC();
            }

            return sum;
        }

        public int NrOfModulesWithExamMark(int mark)
        {
            List<Module> temp = new List<Module>();
            foreach (var module in modules)
            {
                if (module.ExamMark == mark)
                {
                    temp.Add(module);
                }
            }
            return temp.Count;
        }

        public Recommendation GetRecommendation(int MaximumEC)
        {
            if (MaximumEC == this.GetAchievedEC())
            {
                return Recommendation.POSITIVE;
            }
            else if (MaximumEC*0.75 == this.GetAchievedEC())
            {
                return Recommendation.CONDITIONAL_POSITIVE;
            }
            else if (MaximumEC * 0.50 == this.GetAchievedEC())
            {
                return Recommendation.CONDITIONAL_NEGATIVE;
            }
            else
            {
                return Recommendation.NEGATIVE;
            }
        }
    }
}
