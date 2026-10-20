using System;

namespace FormControlInvoke
{
    public static class InvokeExtensions
    {
        /// <summary>
        /// Extension method for acquiring InvokeRequired boolean value and determining whether 
        /// Invoke method should be used to change the values of a form control
        /// </summary>
        /// <param name="control">Form control on which the extension is used</param>
        /// <param name="action">Lambda used to change the forms controls</param>
        /// <exception cref="ArgumentNullException">Control or Action is null when passed to metehod</exception>
        public static void InvokeControlAction(this System.Windows.Forms.Control control, Action action)
        {
            switch (action)
            {
                case null:
                    throw new ArgumentNullException(nameof(action), "Null lambda value");
                default:
                    switch (control.InvokeRequired)
                    {
                        case true:
                            control.Invoke(action);
                            break;
                        case false:
                            action();
                            break;
                        default:
                            throw new ArgumentNullException(nameof(control.InvokeRequired), "Invoke Required in parent object not set to boolean value");
                    }
                    break;
            }
        }
    }
}