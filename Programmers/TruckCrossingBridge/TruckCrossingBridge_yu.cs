using System.Collections.Generic;
using System.Linq;

namespace Programmers.TruckCrossingBridge
{
    public class TruckCrossingBridge_yu : ITruckCrossingBridge
    {
        public int Solution((int bridge_length, int weight, int[] truck_weights) input)
        {
            int   bridge_length = input.bridge_length;
            int   weight        = input.weight       ;
            int[] truck_weights = input.truck_weights;

            int answer = 0;
            int index = 0;
            int nextTruckWeight;
            List<Truck> onBridge = new List<Truck>();
            List<Truck> done = new List<Truck>();

            while (true)
            {
                if (index >= input.truck_weights.Count())
                {
                    nextTruckWeight = 0;
                }
                else
                {
                    nextTruckWeight = input.truck_weights[index];
                }

                if (onBridge.Where(d => d.position < input.bridge_length).Sum(d => d.weight) + nextTruckWeight <= input.weight
                    && onBridge.Where(d => d.position < input.bridge_length).Count() < input.bridge_length
                    && index < input.truck_weights.Count())
                {
                    onBridge.Add(new Truck(input.truck_weights[index], 0));
                    input.truck_weights[index] = 0;
                    index++;
                }

                foreach (var item in onBridge)
                {
                    item.position++;
                }

                if (done.Count == input.truck_weights.Count())
                {
                    break;
                }
                done.Add(onBridge.Find(d => d.position > input.bridge_length));
                onBridge = onBridge.Where(d => d.position <= input.bridge_length).ToList();

                answer++;
            }

            return answer;
        }
    }

    public class Truck
    {
        public int weight;
        public int position;

        public Truck(int weight, int position)
        {
            this.weight = weight;
            this.position = position;
        }
    }
}
