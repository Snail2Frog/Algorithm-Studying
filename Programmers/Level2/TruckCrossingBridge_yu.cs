using System.Collections.Generic;
using System.Linq;

namespace Programmers.Level2
{
    public class TruckCrossingBridge_yu : ITruckCrossingBridge
    {
        public int Solution(int bridge_length, int weight, int[] truck_weights)
        {
            int answer = 0;
            int index = 0;
            int nextTruckWeight;
            List<Truck> onBridge = new List<Truck>();
            List<Truck> done = new List<Truck>();

            while (true)
            {
                if (index >= truck_weights.Count()) 
                {
                    nextTruckWeight = 0;
                }
                else
                {
                    nextTruckWeight = truck_weights[index];
                }

                if (onBridge.Where(d=>d.position < bridge_length).Sum(d=>d.weight) + nextTruckWeight <= weight 
                    && onBridge.Count < bridge_length
                    && index < truck_weights.Count())
                {
                    onBridge.Add(new Truck(truck_weights[index], 0));
                    truck_weights[index] = 0;
                    index++;
                }

                foreach (var item in onBridge)
                {
                    item.position++;
                }
                
                if (done.Count == truck_weights.Count())
                {
                    break;
                }
                done.AddRange(onBridge.Where(d=>d.position > bridge_length).ToList());
                onBridge = onBridge.Where(d=>d.position <= bridge_length).ToList();
                
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
