# WindowsInput

This library is for Windows Forms developers. If work is done in the GUI thread (for example in a method in a Form), any mouse or keyboard activity that the user does while the Form is busy will be played back when the work in the method is done. This library prevents functions that prevents that.

Features:

* Clear mouse buffer
* Clear keyboard buffer

If you do longer work, you should start a different thread and disable controls as appropriate during that work, but if you do shorter work in the GUI thread, you should clear the mouse and keyboard buffer before enabling any disabled controls on your Form.

Install:

```
Install-Package WindowsInputBufferAccess
```

To clear the mouse buffer:

```
WindowsInput.Buffer.FlushMouseBuffer(Handle);
```

To clear the keyboard buffer:

```
WindowsInput.Buffer.FlushKeyboardBuffer(Handle);
```

## Try the demo

Start the project `WindowsInputDemo`.

### The mouse buffer

Click the button `Block form for 3 seconds` and directly after, click the disabled button `Display message box`. Notice that the button gets clicked after 3 seconds.

Check the `Clear the mouse buffer` checkbox and repeat the process. Notice that the button does not get clicked after 3 seconds.

### The keyboard buffer

Click the button `Block form for 3 seconds` and directly after, klick the textbox and type somethoing. Notice that the text gets entered after 3 seconds.

Check the `Clear the keyboard buffer` checkbox and repeat the process. Notice that the text does not get entered after 3 seconds.


## License

Apache License 2.0
