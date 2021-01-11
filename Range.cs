using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TendenciasKataRange
{
    public class Range
    {
        public int[] range;
        public bool leftClosed = false;
        public bool rightClosed = false;
        public int leftEndpoint;
        public int rightEndpoint;

        public Range(string input)
        {
            this.leftClosed = (input[0] == '[') ? true : false;
            this.rightClosed = (input[input.Length - 1] == ']') ? true : false;

            input = input.Trim('(', '[', ')', ']');
            string[] rng = input.Split(',');
            this.leftEndpoint = (this.leftClosed) ? int.Parse(rng[0]) : (int.Parse(rng[0]) + 1);
            this.rightEndpoint = (this.rightClosed) ? int.Parse(rng[1]) : (int.Parse(rng[1]) - 1);

            int size = (this.rightEndpoint - this.leftEndpoint)+1;
            this.range = new int[size];
            int start = this.leftEndpoint;
            for (int i = 0; i < size; i++)
            {
                this.range[i] = start;
                start++;
            }
        }

        public bool Contains(int[] points)
        {

            for (int i = 0; i < points.Length; i++)
            {
                if (!this.range.Contains(points[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool DoesNotContain(int[] points)
        {
            return !this.Contains(points);
        }

        public int[] GetAllPoints()
        {
            return this.range;
        }

        public bool ContainsRange(Range range)
        {
            if(range.leftEndpoint >= this.leftEndpoint && range.rightEndpoint <= this.rightEndpoint)
            {
                return true;
            }
            return false;
        }

        public bool DoesNotContainRange(Range range)
        {
            return !this.ContainsRange(range);
        }

        public int[] EndPoints()
        {
            int[] endPoints = new int[2];
            endPoints[0] = this.leftEndpoint;
            endPoints[1] = this.rightEndpoint;
            return endPoints;
        }

        public bool OverlapsRange(Range range)
        {
            if(range.range.Contains(this.leftEndpoint) || this.range.Contains(range.leftEndpoint))
            {
                return true;
            }
            else if(range.range.Contains(this.rightEndpoint) || this.range.Contains(range.rightEndpoint))
            {
                return true;
            }
            return false;
        }

        public bool DoesNotOverlapRange(Range range)
        {
            return !this.OverlapsRange(range);
        }

        public bool Equals(Range range)
        {
            return this.range.SequenceEqual(range.range);
        }

        public bool DoesNotEqual(Range range)
        {
            return !this.Equals(range);
        }
    }
}
