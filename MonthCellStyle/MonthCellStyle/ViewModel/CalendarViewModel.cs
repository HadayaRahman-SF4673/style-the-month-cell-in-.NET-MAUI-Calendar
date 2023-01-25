namespace MonthCellStyle
{
    public class CalendarViewModel
    {
        public List<DayOfWeek> WeekEndDayList { get; set; }

        public CalendarViewModel()
        {
            this.WeekEndDayList = new List<DayOfWeek>() { DayOfWeek.Sunday, DayOfWeek.Saturday };
        }
    }
}
