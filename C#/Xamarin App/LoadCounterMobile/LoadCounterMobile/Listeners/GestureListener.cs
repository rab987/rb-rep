using Android.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoadCounterMobile.Listeners
{
    public class GestureListener : GestureDetector.SimpleOnGestureListener
    {
        public override bool OnDown(MotionEvent e)
        {
            return true;
        }

        public override bool OnDoubleTap(MotionEvent e)
        {
            return true;
        }
    }
}
