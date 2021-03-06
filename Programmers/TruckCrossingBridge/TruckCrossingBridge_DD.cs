﻿using System.Collections.Generic;
using System.Linq;

namespace Programmers.TruckCrossingBridge
{
    public class TruckCrossingBridge_DD : ITruckCrossingBridge
    {
        public int Solution((int bridge_length, int weight, int[] truck_weights) input)
        {
            int   bridge_length = input.bridge_length;
            int   weight        = input.weight       ;
            int[] truck_weights = input.truck_weights;

            var waitingTrucks = new Queue<Truck>();
            foreach (int truck_weight in input.truck_weights)
            {
                waitingTrucks.Enqueue(new Truck() { Weight = truck_weight });
            }

            int timer = 0;
            var trucksOnBrige = new Queue<Truck>();
            while (true)
            {
                timer++;
                foreach (Truck truck in trucksOnBrige)
                {
                    truck.EllapsedTime++;
                }

                if (trucksOnBrige.Count > 0
                && trucksOnBrige.Peek().EllapsedTime > input.bridge_length)
                {
                    trucksOnBrige.Dequeue();
                }

                if (waitingTrucks.Count > 0)
                {
                    int currentWeight = trucksOnBrige.Sum(t => t.Weight);
                    int nextWeight = waitingTrucks.Peek().Weight;
                    if ((currentWeight + nextWeight) <= input.weight)
                    {
                        trucksOnBrige.Enqueue(waitingTrucks.Dequeue());
                    }
                }

                if (trucksOnBrige.Count == 0)
                {
                    break;
                }
            }

            return timer;
        }

        private class Truck
        {
            public int Weight { get; set; }
            public int EllapsedTime { get; set; } = 1;
        }
    }
}
