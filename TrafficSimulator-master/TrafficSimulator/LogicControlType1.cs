﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using TrafficSimulator;
using TrafficSimulatorUi;

namespace TrafficSimulator
{
    /// <summary>
    /// Specifieke logic control voor kruispunt type 1
    /// </summary>
    public class LogicControlType1 : LogicControl
    {

        public override List<LaneId> Queue { get; protected set; }

        /// <summary>
        /// Maakt een nieuw type 1 kruispunt aan.
        /// </summary>
        /// <param name="intersections">Lijst met andere kruispunten.</param>
        public LogicControlType1(List<IntersectionControl> intersections)
        {
            foreach (IntersectionControl intersection in intersections)
            {
                //toekenen van het eigen kruispunt
                if (intersection.IntersectionType == IntersectionType.TYPE_1)
                {
                    base.Intersection = intersection;
                }

                //toekennen van het kruispunt dat zich rechts van dit kruispunt bevind
                if (intersection.IntersectionType == IntersectionType.TYPE_4)
                {
                    base.IntersectionRight = intersection;
                }

                //toekennen van het kruispunt dat zich links van dit kruispunt bevind
                if (intersection.IntersectionType == IntersectionType.TYPE_3)
                {
                    base.IntersectionLeft = intersection;
                }

                //toekennen van het kruispunt dat zich boven van dit kruispunt bevind
                if (intersection.IntersectionType == IntersectionType.TYPE_5)
                {
                    base.IntersectionTop = intersection;
                }
            }

            base.IntersectionBottom = null;
        }

        /// <summary>
        /// Roadusers een bocht laten maken.
        /// </summary>
        public override void MakeTurn()
        {
            foreach (RoadUser roadUser in Intersection.RoadUsers)
            {
                Point P = roadUser.Location;
                // 270 zuid -- 180 west -- 90 noord -- 0 oost
                // TypexTurn(roadUser, Location ,[x, y] waar die de bocht moet maken,[x,y] plek waar die heen moet)
                // De x bepaald hoe groot de kans is dat de bocht gemaakt moet worden

                if (roadUser is Pedestrian)
                {
                    if (roadUser.Direction == 270)
                    {
                        //rechter baan bocht
                        Type4Turn(roadUser, P, 130, 130, 130, 0);
                        //linker baan bocht
                        Type4Turn(roadUser, P, 266, 130, 400, 130);
                    }
                    else if (roadUser.Direction == 180)
                    {
                        //rechter baan bocht
                        Type4Turn(roadUser, P, 266, 130, 266, 0);
                        //linker baan bocht
                        Type4Turn(roadUser, P, 266, 266, 266, 400);
                    }
                    else if (roadUser.Direction == 90)
                    {
                        //rechter baan bocht
                        Type4Turn(roadUser, P, 266, 266, 400, 266);
                        //linker baan bocht
                        Type4Turn(roadUser, P, 130, 266, 0, 266);
                    }
                    else if (roadUser.Direction == 0)
                    {
                        //rechter baan bocht
                        Type4Turn(roadUser, P, 130, 266, 130, 400);
                        //linker baan bocht
                        Type4Turn(roadUser, P, 130, 130, 130, 0);
                    }
                }
                else
                {
                    //NORTH_INBOUND_LANE
                    if (roadUser.Direction == 270)
                    {
                        // RIGHT_LANE Alleen naar rechts 2 mogenlijkheden
                        // Of 1ste bocht anders altijd tweede mogelijkheid
                        Type1Turn(roadUser, P, 156, 156, 0, 156);
                        Type4Turn(roadUser, P, 156, 186, 0, 186);

                        //LEFT_LANE allen eventueel links afslaan bij de tweede mogelijkheid, met een kans van 1 op 2
                        Type2Turn(roadUser, P, 184, 244, 400, 244);
                    }

                    //EAST_INBOUND_LANE
                    else if (roadUser.Direction == 180)
                    {
                        // RIGHT_LANE Alleen naar rechts 2 mogenlijkheden
                        // Of 1ste bocht anders altijd tweede mogelijkheid
                        Type1Turn(roadUser, P, 244, 156, 244, 0);
                        Type4Turn(roadUser, P, 216, 156, 216, 0);

                        //LEFT_LANE allen eventueel links afslaan bij de tweede mogelijkheid, met een kans van 1 op 2
                        Type2Turn(roadUser, P, 156, 186, 156, 400);
                    }

                    //SOUTH_INBOUND_LANE
                    else if (roadUser.Direction == 90)
                    {
                        // RIGHT_LANE Alleen naar rechts 2 mogenlijkheden
                        // Of 1ste bocht anders altijd tweede mogelijkheid
                        Type1Turn(roadUser, P, 244, 244, 400, 244);
                        Type4Turn(roadUser, P, 244, 216, 400, 216);

                        //LEFT_LANE allen eventueel links afslaan bij de tweede mogelijkheid, met een kans van 1 op 2
                        Type2Turn(roadUser, P, 216, 156, 0, 156);
                    }

                    //WEST_INBOUND_LANE
                    else if (roadUser.Direction == 0)
                    {
                        // RIGHT_LANE Alleen naar rechts 2 mogenlijkheden
                        // Of 1ste bocht anders altijd tweede mogelijkheid
                        Type1Turn(roadUser, P, 156, 244, 156, 400);
                        Type4Turn(roadUser, P, 186, 244, 186, 400);

                        //LEFT_LANE allen eventueel links afslaan bij de tweede mogelijkheid, met een kans van 1 op 2
                        Type2Turn(roadUser, P, 244, 216, 244, 0);
                    }
                }
                }

               
        }

        /// <summary>
        /// Wachtrij voor een stoplich beheren.
        /// </summary>
        public override void HandleTrafficLight()
        {
            foreach (RoadUser roadUser in base.Intersection.RoadUsers)
            {
                //NORTH inbound LEFT AND RIGHT lane
                HandleTrafficLightLane(roadUser, LaneId.NORTH_INBOUND_ROAD_LEFT);
                HandleTrafficLightLane(roadUser, LaneId.NORTH_INBOUND_ROAD_RIGHT);

                //EAST inbound LEFT AND RIGHT lane
                HandleTrafficLightLane(roadUser, LaneId.EAST_INBOUND_ROAD_LEFT);
                HandleTrafficLightLane(roadUser, LaneId.EAST_INBOUND_ROAD_RIGHT);

                //SOUTH inbound LEFT AND RIGHT lane
                HandleTrafficLightLane(roadUser, LaneId.SOUTH_INBOUND_ROAD_LEFT);
                HandleTrafficLightLane(roadUser, LaneId.SOUTH_INBOUND_ROAD_RIGHT);

                //WEST inbound LEFT AND RIGHT lane
                HandleTrafficLightLane(roadUser, LaneId.WEST_INBOUND_ROAD_LEFT);
                HandleTrafficLightLane(roadUser, LaneId.WEST_INBOUND_ROAD_RIGHT);
            }
        }

        /// <summary>
        /// Stoplicht schakelen.
        /// </summary>
        public override void HandleQueue()
        {
            if (Queue.Count > 0)
            {
                if (base.Intersection.GetTrafficLight(LaneId.SOUTH_INBOUND_ROAD_LEFT).State == SignalState.GO ||
                    base.Intersection.GetTrafficLight(LaneId.SOUTH_INBOUND_ROAD_RIGHT).State == SignalState.GO ||
                    base.Intersection.GetTrafficLight(LaneId.EAST_INBOUND_ROAD_LEFT).State == SignalState.GO ||
                    base.Intersection.GetTrafficLight(LaneId.EAST_INBOUND_ROAD_RIGHT).State == SignalState.GO ||
                    base.Intersection.GetTrafficLight(LaneId.WEST_INBOUND_ROAD_LEFT).State == SignalState.GO ||
                    base.Intersection.GetTrafficLight(LaneId.WEST_INBOUND_ROAD_RIGHT).State == SignalState.GO ||
                    base.Intersection.GetTrafficLight(LaneId.NORTH_INBOUND_ROAD_LEFT).State == SignalState.GO ||
                    base.Intersection.GetTrafficLight(LaneId.NORTH_INBOUND_ROAD_RIGHT).State == SignalState.GO)
                {
                    base.Intersection.GetTrafficLight(LaneId.SOUTH_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.SOUTH_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.EAST_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.EAST_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.WEST_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.WEST_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.NORTH_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.NORTH_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                }
                else if (Queue[0] == LaneId.NORTH_INBOUND_ROAD_LEFT)
                {

                    base.Intersection.GetTrafficLight(LaneId.SOUTH_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.SOUTH_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.EAST_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.EAST_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.GO);
                    base.Intersection.GetTrafficLight(LaneId.WEST_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.WEST_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.NORTH_INBOUND_ROAD_LEFT).SwitchTo(SignalState.GO);
                    base.Intersection.GetTrafficLight(LaneId.NORTH_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.GO);
                    Queue.RemoveAt(0);
                }
                else if (Queue[0] == LaneId.NORTH_INBOUND_ROAD_RIGHT || Queue[0] == LaneId.WEST_INBOUND_ROAD_RIGHT || Queue[0] == LaneId.SOUTH_INBOUND_ROAD_RIGHT || Queue[0] == LaneId.EAST_INBOUND_ROAD_RIGHT)
                {

                    base.Intersection.GetTrafficLight(LaneId.SOUTH_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.SOUTH_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.GO);
                    base.Intersection.GetTrafficLight(LaneId.EAST_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.EAST_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.GO);
                    base.Intersection.GetTrafficLight(LaneId.WEST_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.WEST_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.GO);
                    base.Intersection.GetTrafficLight(LaneId.NORTH_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.NORTH_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.GO);
                    Queue.RemoveAt(0);
                }
                else if (Queue[0] == LaneId.WEST_INBOUND_ROAD_LEFT)
                {
                    base.Intersection.GetTrafficLight(LaneId.SOUTH_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.SOUTH_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.EAST_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.EAST_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.WEST_INBOUND_ROAD_LEFT).SwitchTo(SignalState.GO);
                    base.Intersection.GetTrafficLight(LaneId.WEST_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.GO);
                    base.Intersection.GetTrafficLight(LaneId.NORTH_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.NORTH_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.GO);
                    Queue.RemoveAt(0);
                }
                else if (Queue[0] == LaneId.SOUTH_INBOUND_ROAD_LEFT)
                {
                    base.Intersection.GetTrafficLight(LaneId.SOUTH_INBOUND_ROAD_LEFT).SwitchTo(SignalState.GO);
                    base.Intersection.GetTrafficLight(LaneId.SOUTH_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.GO);
                    base.Intersection.GetTrafficLight(LaneId.EAST_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.EAST_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.WEST_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.WEST_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.GO);
                    base.Intersection.GetTrafficLight(LaneId.NORTH_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.NORTH_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.STOP);
                    Queue.RemoveAt(0);
                }
                else if (Queue[0] == LaneId.EAST_INBOUND_ROAD_LEFT)
                {
                    base.Intersection.GetTrafficLight(LaneId.SOUTH_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.SOUTH_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.GO);
                    base.Intersection.GetTrafficLight(LaneId.EAST_INBOUND_ROAD_LEFT).SwitchTo(SignalState.GO);
                    base.Intersection.GetTrafficLight(LaneId.EAST_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.GO);
                    base.Intersection.GetTrafficLight(LaneId.WEST_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.WEST_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.NORTH_INBOUND_ROAD_LEFT).SwitchTo(SignalState.STOP);
                    base.Intersection.GetTrafficLight(LaneId.NORTH_INBOUND_ROAD_RIGHT).SwitchTo(SignalState.STOP);
                    Queue.RemoveAt(0);
                }
            }
        }
    }
}
