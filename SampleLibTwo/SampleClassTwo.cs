using System;
using Android.Content;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Widget;
using Java.Lang;

namespace SampleLibTwo
{
    public class SampleClassTwo : AppCompatTextView
    {
        public SampleClassTwo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public SampleClassTwo(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public SampleClassTwo(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public SampleClassTwo(Context context) : base(context)
        {
        }

        public override void SetText(ICharSequence text, BufferType type)
        {
            Toast.MakeText(this.Context, text, ToastLength.Short).Show();
            base.SetText(text, type);
        }

        public new void SetText(string text, BufferType type)
        {
            Toast.MakeText(this.Context, text, ToastLength.Short).Show();
            base.SetText(text, type);
        }
    }
}