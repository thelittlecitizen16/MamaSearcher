using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MamaSearcher
{
    public class MamaSearcher : IMamaSearcher
    {
        private Dictionary<string, Action<int, string>> _allPatterns;
        public MamaSearcher()
        {
            _allPatterns = new Dictionary<string, Action<int, string>>();
        }
        public void PerformSearch(string content)
        {
            foreach (var pattern in _allPatterns)
            {

                if (content.ToLower().Contains(pattern.Key.ToLower()))
                {
                    int index = content.ToLower().IndexOf(pattern.Key.ToLower().First());
                    pattern.Value(index, pattern.Key);
                }
            }
        }

        public void Subscribe(string pattern, Action<int, string> actionToPerform)
        {
            if (!_allPatterns.ContainsKey(pattern))
            {
                _allPatterns.Add(pattern, actionToPerform);
            }
            else
            {
                _allPatterns[pattern] += actionToPerform;
            }
        }
    }
}
