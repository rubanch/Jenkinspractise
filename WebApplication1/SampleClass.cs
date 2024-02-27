namespace WebApplication1
{
    public class SampleClass
    {
        public String sayJenkins(int times)
        {
            String Output = "";
            for (int i = 0; i < times; i++)
            {
                Output += "Jenkins ";
            }
            return Output;
        }
    }
}
