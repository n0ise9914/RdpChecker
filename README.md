![alt tag](https://raw.githubusercontent.com/n0ise9914/RdpChecker/master/RdpChecker/screenshot/image.png)
# RdpChecker
#### Supported windows servers: from Windows Server 2003 to Windows Server 2008/2012 and even Windows Server 2016
#### This tool can detect successful user login (not just checking user/pass)
Made for authorization checking on plenty number of RDP servers.<br/>
Its not too fast to be used as RDP brute tool, but its very accurate and reliable on checking already cracked RDP's :)
#### Notice: This tool has the opportunity to become a RDP cracker by implementing multi threading.
#### Depends on AxInterop.MSTSCLib and Interop.MSTSCLib

# Usage
1. Create a text file contained RDP's inormation in following format per line.<br/>
```
[Ip Address]:[port]@[Machine name]\[Username];[Password]

example: 4.2.2.4:3389@noise\administrator;root
```
2. Open up the app and click load then start and wait...<br/>
#### Notice: LoggedIn RDP's goes into a file named good.txt beside executable app file.
Notice: The input format is designed to load output of some other rdp crackers that i dont wanna name them here :), but you can easily impelement your own!<br/>
<br/><br/>
#### Contribution's gladly accepted Xx
