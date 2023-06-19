using System.Collections;

namespace homework
{
    public class Repertoire : IEnumerable<Performance>
    {
        public MonthName Month { get; set; }
        public int Year { get; set; }
        List<Performance> listPerformances;
        public int NumPerformances
        {
            get => listPerformances.Count;
        }

        public Repertoire(MonthName month, int year,IEnumerable<Performance> sequence)
        {
            Month = month;
            Year = year;

            List<Performance>newsequence = new List<Performance>();

            foreach (var performance in sequence)
            {
                if (performance.StartDateAndTime.Year == Year &&
                    performance.StartDateAndTime.Month == ConvertMonthANumber(Month))
                {
                    newsequence.Add(performance);
                }
            }

            newsequence.AsEnumerable();
            listPerformances = new List<Performance>(newsequence.Distinct());
        }

        public int ConvertMonthANumber(MonthName month)
        {
            switch (month)
            {
                case MonthName.January:
                    return 1;
                case MonthName.February:
                    return 2;
                case MonthName.March:
                    return 3;
                case MonthName.April:
                    return 4;
                case MonthName.May:
                    return 5;
                case MonthName.June:
                    return 6;
                case MonthName.July:
                    return 7;
                case MonthName.August:
                    return 8;
                case MonthName.September:
                    return 9;
                case MonthName.October:
                    return 10;
                case MonthName.November:
                    return 11;
                default:
                    return 12;
            }
        }

        public IEnumerator<Performance> GetEnumerator() => listPerformances.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

