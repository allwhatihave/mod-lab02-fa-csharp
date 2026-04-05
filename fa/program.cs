using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fans
{
  public class State
  {
    public string Name;
    public Dictionary<char, State> Transitions;
    public bool IsAcceptState;
  }


public class FA1
{
    State s0 = new State() { Name = "s0", IsAcceptState = false, Transitions = new Dictionary<char, State>() };
    State s1 = new State() { Name = "s1", IsAcceptState = false, Transitions = new Dictionary<char, State>() };
    State s2 = new State() { Name = "s2", IsAcceptState = true, Transitions = new Dictionary<char, State>() };
    State dead = new State() { Name = "dead", IsAcceptState = false, Transitions = new Dictionary<char, State>() };

    State InitialState;

    public FA1()
    {
        InitialState = s0;

        // s0
        s0.Transitions['0'] = dead;
        s0.Transitions['1'] = s1;

        // s1 (видели 1)
        s1.Transitions['0'] = s2;
        s1.Transitions['1'] = s1;

        // s2 (ровно один 0 и хотя бы одна 1)
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
    State ee = new State() { Name = "ee", IsAcceptState = false, Transitions = new Dictionary<char, State>() };
    State oe = new State() { Name = "oe", IsAcceptState = false, Transitions = new Dictionary<char, State>() };
    State eo = new State() { Name = "eo", IsAcceptState = false, Transitions = new Dictionary<char, State>() };
    State oo = new State() { Name = "oo", IsAcceptState = true, Transitions = new Dictionary<char, State>() };

    State InitialState;

    public FA2()
    {
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
    State s0 = new State() { Name = "s0", IsAcceptState = false, Transitions = new Dictionary<char, State>() };
    State s1 = new State() { Name = "s1", IsAcceptState = false, Transitions = new Dictionary<char, State>() };
    State s2 = new State() { Name = "s2", IsAcceptState = true, Transitions = new Dictionary<char, State>() };

    State InitialState;

    public FA3()
    {
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
      String s = "01111";
      FA1 fa1 = new FA1();
      bool? result1 = fa1.Run(s);
      Console.WriteLine(result1);
      FA2 fa2 = new FA2();
      bool? result2 = fa2.Run(s);
      Console.WriteLine(result2);
      FA3 fa3 = new FA3();
      bool? result3 = fa3.Run(s);
      Console.WriteLine(result3);
    }
  }
}
