using System;

namespace FormControlInvoke
{
    public static class InvokeExtensions
    {
        public static void InvokeControlAction(this System.Windows.Forms.Control control, Action method)
        {
            if (method == null)
            {
                throw new ArgumentNullException(nameof(method), "Method cannot be null");
            }
            else
            {
                switch (control.InvokeRequired)
                {
                    case true:
                        control.Invoke(method);
                        break;
                    case false:
                        method();
                        break;
                    default:
                        throw new ArgumentNullException(nameof(control), "Invoke Required parent object not set to boolean value");
                }
            }
        }
    }
}
