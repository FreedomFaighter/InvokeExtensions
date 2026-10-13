# Invoke FormInvokeControl

For changing a control with an action while evaluating InvokeRequired

## Include
```csharp
using FormControlInvoke;
```

## Usage
```csharp
fc.InvokeControlAction(new Action() => fc.Text = "New Text" );
```
