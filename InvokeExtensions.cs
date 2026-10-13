using System;

namespace FormControlInvoke
{
    public static class InvokeExtensions
    {
        public static void InvokeControlAction(this System.Windows.Forms.Control control, Action action)
        {
            if (action == null)
            {
                throw new ArgumentNullException(nameof(action), "Method cannot be null");
            }
            else
            {
                switch (control.InvokeRequired)
                {
                    case true:
                        control.Invoke(action);
                        break;
                    case false:
                        action();
                        break;
                    default:
                        throw new ArgumentNullException(nameof(control.InvokeRequired), "Invoke Required parent object not set to boolean value");
                }
            }
        }
    }
}
