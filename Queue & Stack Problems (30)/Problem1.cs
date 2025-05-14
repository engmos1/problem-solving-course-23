using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving_course_23
{
    class Problem1
    {
        //Implement Browser Back Button

        public class BrowserHistory
        {
            private Stack<string> backStack;
            private Stack<string> forwardStack;
            public BrowserHistory(string homepage)
            {
                backStack = new Stack<string>();
                forwardStack = new Stack<string>();
                backStack.Push(homepage);
            }
            public void Visit(string url)
            {
                backStack.Push(url);
                forwardStack.Clear();
            }
            public string Back(int steps)
            {
                while (steps > 0 && backStack.Count > 1)
                {
                    forwardStack.Push(backStack.Pop());
                    steps--;
                }
                return backStack.Peek();
            }
            public string Forward(int steps)
            {
                while (steps > 0 && forwardStack.Count > 0)
                {
                    backStack.Push(forwardStack.Pop());
                    steps--;
                }
                return backStack.Peek();
            }
        }
        static void Main1()
        {
            BrowserHistory browserHistory = new BrowserHistory("leetcode.com");
            browserHistory.Visit("google.com");
            browserHistory.Visit("facebook.com");
            browserHistory.Visit("youtube.com");
            Console.WriteLine(browserHistory.Back(1)); // Output: "facebook.com"
            Console.WriteLine(browserHistory.Back(1)); // Output: "google.com"
            Console.WriteLine(browserHistory.Forward(1)); // Output: "facebook.com"
            browserHistory.Visit("linkedin.com");
            Console.WriteLine(browserHistory.Forward(2)); // Output: "linkedin.com"
            Console.WriteLine(browserHistory.Back(2)); // Output: "google.com"
            Console.WriteLine(browserHistory.Back(7)); // Output: "leetcode.com"

        }
    }
}
