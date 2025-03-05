using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    public class Button
    {
        public delegate void ClickHandler();
        public event ClickHandler? OnClick;

        public void Click()
        {
            if (OnClick != null)
                OnClick.Invoke();
            else
                Console.WriteLine("No event handler attached.");
        }
    }

    public class UIHandler
    {
        public void ShowMessage()
        {
            Console.WriteLine("Button Clicked! Performing Action...");
        }
    }
}
