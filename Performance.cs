namespace homework
{
    public class Performance : IComparable<Performance>
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public DateTime StartDateAndTime { get; set; }

        public string EndTime
        {
            get => StartDateAndTime.AddMinutes(Duration).ToShortTimeString();
        }

        public PerformanceType Type { get; set; }
        public double SurchargeOrDiscount { get; set; }

        public Performance(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }

        public string GetPerformanceTypeName()
        {
            switch (Type)
            {
                case PerformanceType.Usual:
                    return "Обычный";
                case PerformanceType.Premiere:
                    return "Премьера";
                default:
                    return "Последний сезон";
            }
        }
        
        public virtual string GetInfo()
        {
            return $"Название: {Name}. Продолжительность: {Duration} мин. Описание: {Description}. " +
                   $"Дата и время начала: {StartDateAndTime}. Время окончания: {EndTime}. Тип: {GetPerformanceTypeName()}. " +
                   $"Надбавка/скидка: {SurchargeOrDiscount}.";
        }

        public int CompareTo(Performance other)
        {
            return StartDateAndTime.CompareTo(other.StartDateAndTime);
        }
    }
}

