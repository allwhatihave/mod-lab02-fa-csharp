using System;
using System.Collections.Generic;

namespace fans
{
    public class State
    {
        public string Name;
        public Dictionary<char, State> Transitions;
        public bool IsAcceptState;

        public State(string name)
        {
            Name = name;
            Transitions = new Dictionary<char, State>();
        }
    }

    // FA1: ровно один '0' и хотя бы одна '1'
    public class FA1
    {
        State s0, s1, s01, s11, dead;
        State InitialState;

        public FA1()
        {
            s0 = new State("s0");       // старт
            s1 = new State("s1");       // видели хотя бы одну '1', ноль ещё нет
            s01 = new State("s01");     // видели ровно один '0', пока нет '1'
            s11 = new State("s11") { IsAcceptState = true }; // ровно один '0' и хотя бы одна '1'
            dead = new State("dead");   // все остальные случаи

            InitialState = s0;

            // s0
            s0.Transitions['0'] = s01;
            s0.Transitions['1'] = s1;

            // s1
            s1.Transitions['0'] = s11;
            s1.Transitions['1'] = s1;

            // s01
            s01.Transitions['0'] = dead;
            s01.Transitions['1'] = s11;

            // s11
            s11.Transitions['0'] = dead;
            s11.Transitions['1'] = s11;

            // dead
            dead.Transitions['0'] = dead;
            dead.Transitions['1'] = dead;
        }

        public bool? Run(IEnumerable<char> s)
        {
            State current = InitialState;
            foreach (var c in s)
            {
                current = current.Transitions[c];
                if (current == null)
                    return null;
            }
            return current.IsAcceptState;
        }
    }

    // FA2: нечётное количество '0' и нечётное количество '1'
    public class FA2
    {
        State ee, eo, oe, oo;
        State InitialState;

        public FA2()
        {
            ee = new State("ee"); // чётное 0, чётное 1
            eo = new State("eo"); // чётное 0, нечётное 1
            oe = new State("oe"); // нечётное 0, чётное 1
            oo = new State("oo") { IsAcceptState = true }; // нечётное 0, нечётное 1

            InitialState = ee;

            ee.Transitions['0'] = oe;
            ee.Transitions['1'] = eo;

            oe.Transitions['0'] = ee;
            oe.Transitions['1'] = oo;

            eo.Transitions['0'] = oo;
            eo.Transitions['1'] = ee;

            oo.Transitions['0'] = eo;
            oo.Transitions['1'] = oe;
        }

        public bool? Run(IEnumerable<char> s)
        {
            State current = InitialState;
            foreach (var c in s)
            {
                current = current.Transitions[c];
                if (current == null)
                    return null;
            }
            return current.IsAcceptState;
        }
    }

    // FA3: содержит '11'
    public class FA3
    {
        State s0, s1, s2;
        State InitialState;

        public FA3()
        {
            s0 = new State("s0");
            s1 = new State("s1");
            s2 = new State("s2") { IsAcceptState = true };

            InitialState = s0;

            s0.Transitions['0'] = s0;
            s0.Transitions['1'] = s1;

            s1.Transitions['0'] = s0;
            s1.Transitions['1'] = s2;

            s2.Transitions['0'] = s2;
            s2.Transitions['1'] = s2;
        }

        public bool? Run(IEnumerable<char> s)
        {
            State current = InitialState;
            foreach (var c in s)
            {
                current = current.Transitions[c];
                if (current == null)
                    return null;
            }
            return current.IsAcceptState;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = "01111";

            FA1 fa1 = new FA1();
            Console.WriteLine($"FA1('{s}') = {fa1.Run(s)}");

            FA2 fa2 = new FA2();
            Console.WriteLine($"FA2('{s}') = {fa2.Run(s)}");

            FA3 fa3 = new FA3();
            Console.WriteLine($"FA3('{s}') = {fa3.Run(s)}");
        }
    }
}
