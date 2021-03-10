﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrafficSimulatorUi;
using System.Windows.Forms;
using System.Drawing;

namespace TrafficSimulator
{
    public class RandomRoadUsers
    {
        /// <summary>
        /// Totaal aantal gegenereerde roadusers.
        /// </summary>
        public int StatsTotal { get; private set; }
        /// <summary>
        /// Totaal aantal gegenereerde roadusers per kruispunt.
        /// </summary>
        public int[] StatsTotalPerIntersection { get; private set; }
        /// <summary>
        /// Totaal aantal rood licht overtredingen.
        /// </summary>
        public int StatsTotalRedLight { get; private set; }
        /// <summary>
        /// Totaal aantal snelheidsovertredingen.
        /// </summary>
        public int StatsTotalSpeed { get; private set; }
        /// <summary>
        /// ID van de laatst gegenereerde roaduser.
        /// </summary>
        public int StatsLastID
        {
            get
            {
                return lastRoadUser.ID;
            }
        }
        /// <summary>
        /// Snelheid van de laatst gegenereerde roaduser.
        /// </summary>
        public double StatsLastSpeed
        {
            get
            {
                return lastRoadUser.MaxSpeed;
            }
        }
        /// <summary>
        /// Snelheidsovertreding van de laatst gegenereerde roaduser
        /// </summary>
        public bool StatsLastRedlight
        {
            get
            {
                return lastRoadUser.RedLight;
            }
        }
        /// <summary>
        /// Kruispunt type van de laatst gegenereerde roaduser.
        /// </summary>
        public IntersectionType StatsLastIType
        {
            get
            {
                return lastIC.IntersectionType;
            }
        }

        /// <summary>
        /// Random object om random dingen te randomen.
        /// </summary>
        private Random random = new Random();
        /// <summary>
        /// Laatst gegenereerde roaduser
        /// </summary>
        private RoadUser lastRoadUser;
        /// <summary>
        /// Kruispunt waar de laatste roaduser is gegenereerd.
        /// </summary>
        private IntersectionControl lastIC;

        /// <summary>
        /// Lijst met kruispunten
        /// </summary>
        public List<IntersectionControl> Intersections { get; private set; }

        /// <summary>
        /// Nieuwe roaduser generator aanmaken.
        /// </summary>
        /// <param name="intersections">Lijst met kruispunten</param>
        public RandomRoadUsers(List<IntersectionControl> intersections)
        {
            StatsTotalPerIntersection = new int[7];
            Intersections = intersections;
        }

        /// <summary>
        /// Nieuwe random roaduser maken.
        /// </summary>
        /// <param name="spawnX">X locatie voor de roaduser</param>
        /// <param name="spawnY">Y locatie voor de roaduser</param>
        /// <returns></returns>
        private RoadUser pickRandomCar(int spawnX, int spawnY)
        {
            // Snelheid van de roaduser is 2 met een kans van 1 op 5 dat deze een snelheidsovertreding gaat maken.
            double newCarSpeed = 2;
            if (random.Next(0, 10) == 0) newCarSpeed = 3;

            // Kans van 1 op 10 dat de roaduser door een rood licht gaat rijden.
            bool newCarRedLight = (random.Next(0, 10) == 0);

            switch (random.Next(0, 3))
            {
                case 0:
                    return new BlueCar(new Point(spawnX, spawnY), newCarSpeed, newCarRedLight);
                case 1:
                    return new BlueSportsCar(new Point(spawnX, spawnY), newCarSpeed, newCarRedLight);
                case 2:
                    return new GreenSportsCar(new Point(spawnX, spawnY), newCarSpeed, newCarRedLight);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Nieuwe roaduser spawnen
        /// </summary>
        public void SpawnRoadUser()
        {
            RoadUser newRoadUser = null;
            int totalRoadusers = 0;

            foreach (IntersectionControl ic in Intersections)
            {
                totalRoadusers += ic.RoadUsers.Count;
            }

            IntersectionControl intersection = Intersections[random.Next(6)];

            if (totalRoadusers < 300)
            {
                if (intersection.IntersectionType == IntersectionType.TYPE_1)
                {
                    switch (random.Next(4))
                    {
                        case 0:
                            //south inbound left pedestrian
                            newRoadUser = new Pedestrian(new Point(130, 405), 1);
                            newRoadUser.FaceTo(new Point(130, 0));
                            break;
                        case 1:
                            //south inbound left road
                            newRoadUser = pickRandomCar(216, 418);
                            newRoadUser.FaceTo(new Point(216, 0));
                            break;
                        case 2:
                            //south inbound right road
                            newRoadUser = pickRandomCar(244, 418);
                            newRoadUser.FaceTo(new Point(244, 0));
                            break;
                        case 3:
                            //south inbound right pedestrian
                            newRoadUser = new Pedestrian(new Point(266, 405), 1);
                            newRoadUser.FaceTo(new Point(266, 0));
                            break;
                    }
                }
                else if (intersection.IntersectionType == IntersectionType.TYPE_2)
                {
                    switch (random.Next(8))
                    {
                        case 0:
                            //north inbound left pedestrian
                            newRoadUser = new Pedestrian(new Point(266, -5), 1);
                            newRoadUser.FaceTo(new Point(266, 400));
                            break;
                        case 1:
                            //north inbound right lane
                            newRoadUser = pickRandomCar(156, -18);
                            newRoadUser.FaceTo(new Point(156, 400));
                            break;
                        case 2:
                            //north inbound left lane
                            newRoadUser = pickRandomCar(186, -18);
                            newRoadUser.FaceTo(new Point(186, 400));
                            break;
                        case 3:
                            //north inbound right pedestrian
                            newRoadUser = new Pedestrian(new Point(130, -5), 1);
                            newRoadUser.FaceTo(new Point(130, 400));
                            break;
                        case 4:
                            //west inbound left pedestrian
                            newRoadUser = new Pedestrian(new Point(-5, 130), 1);
                            newRoadUser.FaceTo(new Point(400, 130));
                            break;
                        case 5:
                            //west inbound left lane
                            newRoadUser = pickRandomCar(-18, 216);
                            newRoadUser.FaceTo(new Point(400, 216));
                            break;
                        case 6:
                            //west inbound right lane
                            newRoadUser = pickRandomCar(-18, 244);
                            newRoadUser.FaceTo(new Point(400, 244));
                            break;
                        case 7:
                            //west inbound right pedestrian
                            newRoadUser = new Pedestrian(new Point(-5, 266), 1);
                            newRoadUser.FaceTo(new Point(400, 266));
                            break;
                    }
                }
                else if (intersection.IntersectionType == IntersectionType.TYPE_3)
                {
                    switch (random.Next(8))
                    {
                        case 0:
                            //south inbound left pedestrian
                            newRoadUser = new Pedestrian(new Point(130, 405), 1);
                            newRoadUser.FaceTo(new Point(130, 0));
                            break;
                        case 1:
                            //south inbound left lane
                            newRoadUser = pickRandomCar(216, 418);
                            newRoadUser.FaceTo(new Point(216, 0));
                            break;
                        case 2:
                            //south inbound right lane
                            newRoadUser = pickRandomCar(244, 418);
                            newRoadUser.FaceTo(new Point(244, 0));
                            break;
                        case 3:
                            //south inbound right pedestrian
                            newRoadUser = new Pedestrian(new Point(266, 405), 1);
                            newRoadUser.FaceTo(new Point(266, 0));
                            break;
                        case 4:
                            //west inbound left pedestrian
                            newRoadUser = new Pedestrian(new Point(-5, 130), 1);
                            newRoadUser.FaceTo(new Point(400, 130));
                            break;
                        case 5:
                            //west inbound left lane
                            newRoadUser = pickRandomCar(-18, 216);
                            newRoadUser.FaceTo(new Point(400, 216));
                            break;
                        case 6:
                            //west inbound right lane
                            newRoadUser = pickRandomCar(-18, 244);
                            newRoadUser.FaceTo(new Point(400, 244));
                            break;
                        case 7:
                            //west inbound right pedestrian
                            newRoadUser = new Pedestrian(new Point(-5, 266), 1);
                            newRoadUser.FaceTo(new Point(400, 266));
                            break;
                    }
                }
                else if (intersection.IntersectionType == IntersectionType.TYPE_4)
                {
                    switch (random.Next(8))
                    {
                        case 0:
                            //south inbound left pedestrian
                            newRoadUser = new Pedestrian(new Point(130, 405), 1);
                            newRoadUser.FaceTo(new Point(130, 0));
                            break;
                        case 1:
                            //south inbound left lane
                            newRoadUser = pickRandomCar(216, 418);
                            newRoadUser.FaceTo(new Point(216, 0));
                            break;
                        case 2:
                            //south inbound right lane
                            newRoadUser = pickRandomCar(244, 418);
                            newRoadUser.FaceTo(new Point(244, 0));
                            break;
                        case 3:
                            //south inbound right pedestrian
                            newRoadUser = new Pedestrian(new Point(266, 405), 1);
                            newRoadUser.FaceTo(new Point(266, 0));
                            break;
                        case 4:
                            //east inbound left pedestrian
                            newRoadUser = new Pedestrian(new Point(405, 130), 1);
                            newRoadUser.FaceTo(new Point(0, 130));
                            break;
                        case 5:
                            //east inbound right lane
                            newRoadUser = pickRandomCar(418, 156);
                            newRoadUser.FaceTo(new Point(0, 156));
                            break;
                        case 6:
                            //east inbound left lane
                            newRoadUser = pickRandomCar(418, 186);
                            newRoadUser.FaceTo(new Point(0, 186));
                            break;
                        case 7:
                            //east inbound right pedestrian
                            newRoadUser = new Pedestrian(new Point(405, 266), 1);
                            newRoadUser.FaceTo(new Point(0, 266));
                            break;
                    }
                }
                else if (intersection.IntersectionType == IntersectionType.TYPE_5)
                {
                    switch (random.Next(4))
                    {
                        case 0:
                            //north inbound left pedestrian
                            newRoadUser = new Pedestrian(new Point(130, -5), 1);
                            newRoadUser.FaceTo(new Point(130, 400));
                            break;
                        case 1:
                            //north inbound right lane
                            newRoadUser = pickRandomCar(156, -18);
                            newRoadUser.FaceTo(new Point(156, 400));
                            break;
                        case 2:
                            //north inbound left lane
                            newRoadUser = pickRandomCar(186, -18);
                            newRoadUser.FaceTo(new Point(186, 400));
                            break;
                        case 3:
                            //north inbound right pedestrian
                            newRoadUser = new Pedestrian(new Point(266, -5), 1);
                            newRoadUser.FaceTo(new Point(266, 400));
                            break;
                    }
                }
                else if (intersection.IntersectionType == IntersectionType.TYPE_RAILWAY)
                {
                    switch (random.Next(4))
                    {
                        case 0:
                            //east inbound left pedestrian
                            newRoadUser = new Pedestrian(new Point(405, 130), 1);
                            newRoadUser.FaceTo(new Point(0, 130));
                            break;
                        case 1:
                            //east inbound right lane
                            newRoadUser = pickRandomCar(418, 156);
                            newRoadUser.FaceTo(new Point(0, 156));
                            break;
                        case 2:
                            //east inbound left lane
                            newRoadUser = pickRandomCar(418, 186);
                            newRoadUser.FaceTo(new Point(0, 186));
                            break;
                        case 3:
                            //east inbound right pedestrian
                            newRoadUser = new Pedestrian(new Point(405, 266), 1);
                            newRoadUser.FaceTo(new Point(0, 266));
                            break;
                    }
                }

                if (newRoadUser != null)
                {
                    intersection.AddRoadUser(newRoadUser);
                    UpdateStats(newRoadUser, intersection);
                }
            }
        }

        /// <summary>
        /// Statistieken bijwerken.
        /// </summary>
        /// <param name="roadUser"></param>
        /// <param name="intersection"></param>
        private void UpdateStats(RoadUser roadUser, IntersectionControl intersection)
        {
            lastRoadUser = roadUser;
            lastIC = intersection;

            StatsTotal++;

            if (roadUser.MaxSpeed >= 4) StatsTotalSpeed++;
            if (roadUser.RedLight) StatsTotalRedLight++;

            if (intersection.IntersectionType == IntersectionType.TYPE_1) StatsTotalPerIntersection[0]++;
            else if (intersection.IntersectionType == IntersectionType.TYPE_2) StatsTotalPerIntersection[1]++;
            else if (intersection.IntersectionType == IntersectionType.TYPE_3) StatsTotalPerIntersection[2]++;
            else if (intersection.IntersectionType == IntersectionType.TYPE_4) StatsTotalPerIntersection[3]++;
            else if (intersection.IntersectionType == IntersectionType.TYPE_5) StatsTotalPerIntersection[4]++;
            else if (intersection.IntersectionType == IntersectionType.TYPE_RAILWAY) StatsTotalPerIntersection[5]++;
        }
    }
}