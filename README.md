# VolMan
Controlling ALSA Mixer remotely

Not exactly perfect code but maybe an starting point or example for someone else.

volman.py is the server that should have ALSA running.

VolControl is a WinForms application that can control the volume of the device that is running volman.py

## Example Usage

I use the python script (volman.py) on my audio pi to avoid adjusting my amplifier when switching audio sources.
Now I can control the volume of all sources within one app without modifying the output of each device individually on each switch.
