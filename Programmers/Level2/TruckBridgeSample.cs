using System;
using System.Collections.Generic;
using System.Text;

namespace Programmers.Level2
{
    public class TruckBridgeSample
    {
        public int bridge_lenth;
        public int weight;
        public int[] truck_weights;

        public TruckBridgeSample(int bridge_lenth, int weight, int[] truck_weights)
        {
            this.bridge_lenth = bridge_lenth;
            this.weight = weight;
            this.truck_weights = truck_weights;
        }
    }
}
