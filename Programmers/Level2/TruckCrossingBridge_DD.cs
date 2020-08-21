﻿using System.Collections.Generic;
using System.Linq;

namespace Programmers.Level2
{
    public class TruckCrossingBridge_DD : ITruckCrossingBridge
    {
        public int Solution(int bridge_length, int weight, int[] truck_weights)
        {
            var trucks = new Queue<Truck>();
            foreach(int truck_weight in truck_weights)
            {
                trucks.Enqueue(new Truck() { Weight = truck_weight });
            }

            int timer = 0;
            var trucksOnBrige = new Queue<Truck>();
            while(true)
            {
                timer++;
                foreach(Truck truck in trucksOnBrige)
                {
                    truck.EllapsedTime++;
                }

                if(trucksOnBrige.Count > 0
                && trucksOnBrige.Peek().EllapsedTime > bridge_length)
                {
                    trucksOnBrige.Dequeue();
                }

                if(trucks.Count > 0)
                {
                    int currentWeight = trucksOnBrige.Sum(t=>t.Weight);
                    int nextWeight    = trucks.Peek().Weight;
                    if((currentWeight + nextWeight) <= weight)
                    {
                        trucksOnBrige.Enqueue(trucks.Dequeue());
                    }
                }

                if(trucksOnBrige.Count == 0)
                {
                    break;
                }
            }

            return timer;
        }

        private class Truck
        {
            public int Weight       { get; set; }
            public int EllapsedTime { get; set; } = 1;
        }
    }
}