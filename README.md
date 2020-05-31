# VolMan
VolMan is a tiny .NET Core 3.1 WinForms application that can control the volume of the Unix devices using ALSA and Python.

I wrote this application many to scratch my own itch that is why the UI is written in C# and WinForms. The "Protocol" if you want to call it like that is platform agnostic.

Improvements can be made with the daemon, Python was choosen for prototyping and might not be the best for the task at hand. Also making the frontend more multi platform friendly  would be a big improvement as well as documenting the protocol.

## Usage

Run unix/volman.py on the ALSA Host output you want to control. That host script can run anywhere as long it can receive data on TCP Port 5055.

### Real world example

I use the python script (volman.py) on my Raspberry Pi in my sound system to avoid adjusting my amplifier when switching between audio sources.
