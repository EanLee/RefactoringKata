namespace Practice
{
    public class LabRename
    {
        public void Main()
        {
            // 請將 aaaa 更名為 counter
            var aaaa = 1;

            for (var i = 0; i < 10; i++)
            {
                if (aaaa == 5)
                {
                    continue;
                }

                aaaa++;
            }
        }
    }
}