using System.Collections.Generic;


namespace Unit06.Game.Scripting
{

    public class Script
    {
        private Dictionary<string, List<Action>> _actions = new Dictionary<string, List<Action>>();

        public Script()
        {
        }

        public void AddAction(string group, Action action)
        {
            if (!_actions.ContainsKey(group))
            {
                _actions[group] = new List<Action>();
            }

            if (!_actions[group].Contains(action))
            {
                _actions[group].Add(action);
            }
        }

        public List<Action> GetActions(string group)
        {
            List<Action> results = new List<Action>();
            if (_actions.ContainsKey(group))
            {
                results.AddRange(_actions[group]);
            }
            return results;
        }

        public void RemoveActor(string group, Action action)
        {
            if (_actions.ContainsKey(group))
            {
                _actions[group].Remove(action);
            }
        }

    }
}