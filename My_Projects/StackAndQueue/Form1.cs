using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackAndQueue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // QUEUE
            Queue<string> myQueue = new Queue<string>();

            myQueue.Enqueue("First in que");
            myQueue.Enqueue("Second in que");
            myQueue.Enqueue("Third in que");
            myQueue.Enqueue("Last in que");

            string takeALook = myQueue.Peek();
            string getFirst = myQueue.Dequeue();
            string getNext = myQueue.Dequeue();
            int howMany = myQueue.Count;

            myQueue.Clear();
            MessageBox.Show("Peek () returned : " + takeALook + "\n"
                + "First Dequeue() returned: " + getFirst + "\n"
                + "Second Deqeue() returned " + getNext + "\n"
                + "Count in front of Clear() was equal" + howMany + "\n"
                + "Count after CLear() is equal " + myQueue.Count);

            //STACK

            Stack<string> myStack = new Stack<string>();

            myStack.Push("First on Stack");
            myStack.Push("Second on Stack");
            myStack.Push("Third on Stack");
            myStack.Push("Last on Stack");

            string takeALookInStack = myStack.Peek();
            string getFirstInStack = myStack.Pop();
            string getNextInStack = myStack.Pop();
            int howManyInStack = myStack.Count;
            myStack.Clear();



            MessageBox.Show("Peek () returned : " + takeALookInStack + "\n"
                + "First Pop() returned: " + getFirstInStack + "\n"
                + "Second Pop() returned " + getNextInStack + "\n"
                + "Count in front of Clear() was equal" + howManyInStack + "\n"
                + "Count after CLear() is equal " + myQueue.Count);


        }
    }
}
