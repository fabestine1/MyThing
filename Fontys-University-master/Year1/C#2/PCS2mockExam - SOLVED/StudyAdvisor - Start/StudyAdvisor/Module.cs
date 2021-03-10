namespace StudyAdvisor
{
    public class Module
    {
        private string code;
        private int eC;
        private int examMark;
        private bool passedPractical;

        public string Code { get => code; set => code = value; }
        public int EC { get => EC;
            set
            {
                if (value > 0)
                {
                    this.eC = value;
                }
            }
        }

        public int ExamMark { get => examMark;
            set
            {
                if (value > 0 && value <= 10)
                {
                    this.examMark = value;
                }
            }
        }

        public bool PassedPractical
        {
            get { return passedPractical; }
            set { passedPractical = value; }
        }

        public Module(string code, int eC, int examMark, bool passedPractical)
        {
            this.code = code;
            this.eC = eC;
            this.examMark = examMark;
            this.passedPractical = passedPractical;
        }

        public int GetAchievedEC()
        {
            if (this.examMark > 5 && passedPractical)
            {
                return EC;
            }
            else
            {
                return 0;
            }
        }


        public string AsString()
        {
            return $"{this.code} ({this.eC} EC's))  exam mark - {this.examMark} passed practical - " +
                   $"{this.passedPractical} achieved EC's - {GetAchievedEC()}";
        }
    }
}
