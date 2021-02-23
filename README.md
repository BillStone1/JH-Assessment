# JH-Assessment

I am embarrassed to submit an incomplete code sample.  

Thus far, I have created a developer account and gotten the keys.
I am able to start the tweet downloads with a cUrl command 
curl -X GET -H "Authorization: Bearer <Bearer Token>" "https://api.twitter.com/2/tweets/sample/stream"

Yet, when I attempt the tweet downloads in Visual Studio C# code I get error messages as shown in the /Images screen shots:
The codelines listed in some of the exceptions are included in /Images/CodeLinesView.png
The initial exception I recieved is in /Images/InitialException.png file
Once I resolved that particular exception I began recieving the exception shown in 
	/Images/SubmissionException.png file
Researching this, I have identified that .GetResponse (line 26) causes 4 errors as shown in the 
	/Image/UnresolvedExceptions.png file. This results in an error in the StreamReader ReadToEnd
	since it has no response to read.

I am determined to resolve this, and If I were part of the Jack Henry team I would have already
searched out someone who could possibly have provided some guidance for this issue!  
Just as I would encourage any other team member to do!! 

I have thus far been unable to resolve these 4 exceptions, but will continue. If you could 
provide any guidance that would be GREATLY appreciated. Whether I am invited to join the team or not!! 

My Bearer token is in the password protected /Images/BillStone.txt.Zip file
	Since I am unsure how to secure this in GIT at this time, the pwd for it is Xqs30mwa#%. 
	I will regenerate the keys on Wednesday as a safegard due to this. 
	
	Bill Stone

