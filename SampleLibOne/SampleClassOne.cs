using System;
using Android.Content;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Widget;
using Java.Lang;

namespace SampleLibOne
{
    public class SampleClassOne : AppCompatTextView
    {
        public SampleClassOne(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public SampleClassOne(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public SampleClassOne(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public SampleClassOne(Context context) : base(context)
        {
        }

        public override void SetText(ICharSequence text, BufferType type)
        {
            Toast.MakeText(this.Context, text, ToastLength.Short);
            base.SetText(text, type);
        }
    }
}