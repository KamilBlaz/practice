using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceV2
{
    class MySubclass : MyBaseClass
    {
        public MySubclass(string baseClassNeedsThis,int anotherValue):base(baseClassNeedsThis){
            MessageBox.Show("To jest klasa pochodona: " + baseClassNeedsThis + "i " + anotherValue);

        }
    }
}
