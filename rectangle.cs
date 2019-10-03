namespace homework_week_1_part_2
{
    public class rectangle
    {
        private int length;
        private int width;
        public rectangle(int length, int width)
        {
            this.length=length;
            this.width=width;
        }
        public int area()
        {
        return this.length*this.width;
        }
    }
}