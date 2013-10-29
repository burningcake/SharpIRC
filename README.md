SharpIRC
========

Tiny IRC Client in C#


BCIRC 
- Helpfile -

1.0
How to use the program.
Basically you have to have some stuff installed first before you can even start this program.
To start the BCIRC GUI you have to install the following frameworks:
- .NET Framework 4.0 or newer 
1.1
How to connect to a server and start chatting.
Before you can start communicating you have to find a server and its conditions .
Those conditions / details have to be defined in the program itself .
You only have to do this step whenever you want to join a new server or channel.
(For changing to another channel you can simply enter "/join #CHANNELNAME" )
To enter these informations you have to do this steps :
1. Start the IRC GUI
2. Click "Show Options" 
3. Look for the "Server" Groupbox and fill in : 
					# Server URL (The server domain) e.g irc.google.de
					# Channel (the channel you want to join) e.g #Doom
					# Port (default port for most servers is 6667)
					# Nickname (Primary Nickname)
					# Alternative Nickname (in case of duplication)
4. Click "Save this settings"
5. Click "Hide Options"
6. Click IRC -> Connect
7. Now you are successfully connected to a IRC server !

2.0
Special Features.
2.1 
Whispers
To whisper to another channel member rightclick his name in the right listbox 
and click Whisper to .
Now just enter your text to be whispered  and hit RETURN.
Done.
2.2
Commands
/exit (will instantly close the whole application.)
/msg $nickname $message (whisper a member)
/admin (writes down hows the admin in your channel)
