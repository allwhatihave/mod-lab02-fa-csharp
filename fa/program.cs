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

    public class FA1
    {
        State s0, s1, s2, dead;
        State InitialState;

        public FA1()
        {
            s0 = new State("s0");
            s1 = new State("s1");
            s2 = new State("s2") { IsAcceptState = true };
            dead = new State("dead");

            InitialState = s0;

            // s0
            s0.Transitions['0'] = s2;
            s0.Transitions['1'] = s1;

            // s1
            s1.Transitions['0'] = s2;
            s1.Transitions['1'] = s1;

            // s2
            s2.Transitions['0'] = dead;
            s2.Transitions['1'] = s2;

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

    public class FA2
    {
        State ee, oe, eo, oo;
        State InitialState;

        public FA2()
        {
            ee = new State("ee");
            oe = new State("oe");
            eo = new State("eo");
            oo = new State("oo") { IsAcceptState = true };

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
            Console.WriteLine(fa1.Run(s));

            FA2 fa2 = new FA2();
            Console.WriteLine(fa2.Run(s));

            FA3 fa3 = new FA3();
            Console.WriteLine(fa3.Run(s));
        }
    }
}
