# RollPlay
_Developed by the Dungeon and Designers team (Group 11)_:<br/>
- **Brittany Pysar**  (brittany.kinden@ucalgary.ca)  
- **Ines Rosito**     (ines.rosito@ucalgary.ca)  
- **Julio Agostini**  (julio.agostini@ucalgary.ca)  
- **Shreya Patel**    (shreya.patel1@ucalgary.ca)  

## Running the App
Due to compatibility issues that can arise, please ensure that you are attempting to run the program using a Windows environment. 

For this application to run correctly, we have to have .NET installed in our environment. So, if you  don’t have an IDE downloaded already, you can download the Visual Studios Community version with .Net, found [here](https://visualstudio.microsoft.com/downloads/), or you can download .NET directly from [here](https://dotnet.microsoft.com/en-us/download).

Say you have gone the route of installing VS, you will be prompted to select potential add-ons. In this scenario you should click `.NET desktop development`.
Now if you open the code base using Visual Studios, you should be able to build the solution and click the `play` button to run the program. 

Alternatively, if you’ve installed successfully installed .NET onto your system directly, navigate to the directory you’ve downloaded the code base to and enter the `\RollPlay` directory (ie. `<File Path\RollPlay\RollPlay>`. From there you should then be able to run the program by typing `dotnet run` into the console.

<hr />

## Use Cases

### Signing In and Signing Up
Each time you start the program, you will be automatically brought to the Sign In page. On this page you are prompted for two inputs, your email and password. For the sake of the demo, to access the rest of the application you must simply enter non-empty strings in **both** input fields. To disregard the input fields and immediately click "Sign In," will result in an error message appearing.

From the Sign In page, you can also access the Sign-Up page. It functions under the same premise as the Sign In page. You must provide valid arguments (ie. Non-empty strings) for all input fields and also ensure the passwords are identical, failure to meet these requirements will result in an error message.

Successful sign in or sign up will then redirect you to the application’s main pages (ie. The collections page). 

### Scheduling a session
Once logged in, you will see your characters. You're going to want to move to the party section on that page by clicking the Party button at the top there. You will see some parties in there already but let's start fresh. 

1. Click create a party button at the bottom of the page 
2. Give your party a name. Be cool and join with a character. 
3. Now that you created a party you will automatically directed to the party page. You are all alone in there for now. 
4. Click the `+` on top of your character and as many friends as you want. They are all really excited they'll accept your request right away 
5. Click on availability and go to party availability. 
6. You will see that it is empty so click on the request availability button at the bottom.
7. Now if you scroll down, you will notice that there are some blocks with availabilities (They were always there just didn't want to ruin the illusion) 
8. Click on any of the blocks and you will see who is available at each time 
9. Decide a time 
10. Click schedule session and select the time and date. 
11. Click create session and you will see the next session under upcoming sessions.

### Updating Your Availability
Now we'll take a look at the other side of this process. The DM will schedule a session, now you, will give him your availability. Let's start in the notifications page. You can go there by clicking the bell icon on the navbar.

1. Click on the notification that says that the DM has requested your availability.
2. Click on edit availability
3. Click and drag on the boxes to select times you're available. 
4. Undo your previous change with the undo button
5. Redo what you just Undid to check it out.
6. Add a block for all day Saturday and Sunday
7. Remove those same blocks you just add it.
8. Clear your entire availability because you're indecisive
9. Select all since you realized you don't really have a life.
10. Click on the update button.
11. You should now see your updated availability show up in the `My Availability` page

### Finding Someone in the Tavern
Let's pretend you got a party, but you need that one last person to complete your party. To do this you're going to want to click on the Tavern icon at the bottom

1. Click `I'm looking for players` button.
2. Enter whatever filters you want.
3. Click `Filter Users` at the bottom.
4. Make sure you read all the rules of the Tavern because those are very important.
5. Proceed.
6. Divulge your deepest darkest secrets in the chat. The juicier, the better.
7. Click on the meatball menu on the top right
8. Click on view users in chat.
9. Invite one of them to your party. Not Bob though he didn't even come up with a good name.

### Learning about D&D
Now, let's say you are new to D&D and you want to learn how to play. You're going to need to start at the Tavern again so head over there.

1. Click on the `I'm new to D&D` button at the top.
2. Choose something that you want to learn about.
3. once you read everything, you can click the back button on the top or the `I've heard enough` button at the bottom to go back and learn about something else.
4. You can also click `Tell me more` to get some more information.
5. Click on the link to be redirected to `D&D Beyond` for some more in-depth information
4. Repeat this for every section so you are caught up with all the latest info on D&D

### Chatting
Now let's say you want to have a normal chat with one of your friends on the app. There are many ways to chat, along with different types of chat. You can open your party chat in the parties page or talk to one of your friends in the friends page. There is also a lot of chat options in the chat menu at the bottom. Let's try the most interactive one we have though.

1. Click on the chat button on the nav bar
2. Click on `Other Chats` at the top
3. Click on the second chat there with `Dragon's Bane`
4. Tell him about your hesitation to kill Thorin.
5. Press `F1`
6. Tell him he has nothing to worry about. You'll do what must be done. Momma didn't raise no quitter. Right?
7. Press `F2`
8. You are well prepared so make sure `Dragon's Bane` knows that.
9. Press `F3`
10. Give him some closing remarks.

There are a few other things you can do. Explore and have fun. Check out some of your parties and add people to them. Maybe even create another party and then delete them all. Check out what characters you have, create one then delete them, you choose. Same thing with your friends. Because why not add some and then delete them all anyways. Try updating your availability and see what the other side of the scheduling works. However, not everything is implemented. Most of the submenu buttons do not work. The settings are not implemented yet and you cannot look at other peoples profile.

