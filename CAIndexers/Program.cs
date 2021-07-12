using System;

namespace CAIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ip = new IP(112, 114, 55, 33);
            var ip = new IP("112.114.55.33");

            var firstSegment = ip[0];

            Console.WriteLine($"IP ADDRESS: {ip.Address}");
            Console.WriteLine($"First Segment: {firstSegment}");

            Console.ReadKey();
        }
    } 

    public class IP
    {
        private int[] segments = new int[4];

        public int this[int index]
        {
            get
            {
                return segments[index];
            }
            set
            {
                segments[index] = value;
            }
        }

        // segment 1-255
        public IP(string IPAddress) // 123.123.123.123
        {
            var segs = IPAddress.Split(".");

            for (int i = 0; i < segs.Length; i++)
            {
                segments[i] = Convert.ToInt32(segs[i]);
            }
        }
        public IP(int segment1, int segment2, int segment3, int segment4 )
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;
        }

        public string Address => string.Join(".", segments);
    }
}
