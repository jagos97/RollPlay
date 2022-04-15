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
Each time you start the program, you will be automatically brought to the Sign In page. On this page you are prompted for two inputs, your email and password. For the sake of the demo, to access the rest of the application you must simply enter non-empty strings in **both** input fields. To disregard the input fields and immediately click `Sign In,` will result in an error message appearing.

From the Sign In page, you can also access the Sign-Up page. It functions under the same premise as the Sign In page. You must provide valid arguments (ie. Non-empty strings) for all input fields and also ensure the passwords are identical, failure to meet these requirements will result in an error message.

Successful sign in or sign up will then redirect you to the application’s main pages (ie. The collections page). 

### Managing Collections
Upon signing in for the session, you will automatically be brought to the Collections page. Within this page you can manage your Characters, Parties, and Friends. To toggle between these different categories, you must simply click the respective subnav item. Upon clicking the desired subview, the page will automatically update.<br/>
![image](https://user-images.githubusercontent.com/33527005/163526341-27729cf0-adde-4663-a707-9d404becf6e6.png)

While focusing on the Character content, you will be to click on the characters to reveal more information about them and click on the meatball menu (`…`) to edit or remove them. The Party content is essentially identical in functionality to the Character subview, however, it focuses on Parties as the name so aptly applies. 

From within the Friends view, you should be able to review the friends you currently have, review your pending friend requests, remove friends, and send out friend requests. 

#### Editing Characters
On the note of editing existing characters, the current implementation restricts input based on the argument it represents in the Character info (ie. Stats and level can only be numbers, all other fields have a 32 character limit). However, if no data is provided for any arguments and the `Save` button is clicked, all values of the original character will be overwritten with empty fields.

### Scheduling a Session
To schedule a session, you must first login where you'll find yourself on the Characters Collection page. You're then going to want to move to the Party subview by clicking the `Party` option in the subnav at the top of the page. You will see some parties in there already but let's start fresh. 

1. Click `Create a Party` button at the bottom of the page 
2. Give your party a name. Be cool and join with a character. 
3. Now that you created a party you will automatically be directed to the Party Page. You are all alone in there for now. 
4. Click the `+` on top of your character and as many friends as you want. They are all really excited they'll accept your request right away 
5. Click on `Availability` and click on `Party Availability` on the subnav at the top of the page. 
6. You will see that it is empty so click on the `Request Availability` button at the bottom.
7. Now if you scroll down and to the right, you will notice that there are some blocks with availabilities (They were always there, just didn't want to ruin the illusion) 
8. Click on any of the blocks right where the text is and you will see who is available at each time 
9. Based on the overall Party availability, decide on a date and time. 
10. Click `Schedule Session` 
11. Select your desired Date and see the text under the calendar automatically update.
12. Then click on the `Time` subnav at the top of the modal and fill out the time slots appropriately! Be sure that your start time is after your end time, or else you will be provided with an error message. 
13. Once content with the time set, click `Create Session` and you will see the next session appear under "Upcoming Sessions".

### Updating Your Availability
Now we'll take a look at the other side of this process. The DM will be the one to schedule a session for the group, but you must now provide him with your availability. Let's start in the Notifications Page. You can go there by clicking the bell icon on the navbar.

1. Identify the notification that is for a Scheduling Request
2. From that notification click on the `See Availability` option to be redirected to the Party's respective scheduling view
3. Click on the `Edit Availability` button
4. Click and drag on the boxes to select times you're available. 
5. Undo your previous change with the `Undo` button
6. Click on `Redo` to redo what you just undid to check it out.
7. Add blocks that cover the duration of all of Saturday and Sunday.
8. Click one block you've just added to remove your availability for one time slot.
9. Click on the `Clear All` button to clear your entire availability because you're indecisive
10. Click on `Select All` since you've realized you don't really have a life.
11. Click on the `Update` button.
12. You should now see your updated availability show up in the `My Availability` page

### Finding Someone in the Tavern
Let's pretend you've currently have a party, in need of that one last person. But you don't have any more friends who play, so you've got to reach out to random individuals on the internet. To find the one, you're going to want to click on the beer icon at the bottom to visit the Tavern

1. Click `I'm looking for players` button.
2. Enter whatever filters you want, you may leave all options as not selected if you're desperate to find anyone.
3. Scroll down and click the `Filter Users` button at the bottom.
4. Make sure you read all the rules of the Tavern to understand what is expected of you.
5. Scroll down and click on the `Proceed` button. Doing so will automatically find people for you and put you all in a chat together.
6. Divulge your deepest darkest secrets in the chat. The juicier, the better.
7. Click on the meatball menu (`...`) on the top right
8. Click on the `View Users in Chat` submenu option to open a modal containing all characters.
9. Click on the kebab icon associated with each user and click the `Invite to Party` option. Don't invite Bob though, he didn't even come up with a good name. 

Upon successfully inviting the user to a party a modal will appear to inform you that they have recieved the invitation. Now all you can do is sit and wait for the other user to accept your invite.

### Learning about D&D
Now, let's say you are new to D&D and you want to learn how to play. You're going to need to start at the Tavern again so lets head on over.

1. Click on the `I'm new to D&D` button at the top.
2. Choose on one of the buttons representating a topic you want to learn about.
3. Once you read everything, you can click the back button on the top or the `I've heard enough` button at the bottom to go back and learn about something else.
4. With this new topic selected, click on the click `Tell me more` option to get some more information.
5. Click on the link to be redirected to `D&D Beyond` for some more in-depth information
4. Repeat this for every section so you are caught up with all the latest info on D&D

### Chatting
Now let's say you want to have a normal chat with one of your friends on the app. There are many ways to chat, along with different types of chat. You can open your party chat in the parties page or talk to one of your friends in the friends page. There is also a lot of chat options in the chat menu at the bottom. Let's try the most interactive one we have though.

1. Click on the chat button on the navbar
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

### Managing Notifications
Notifications are where you can go to see an overview of upcoming sessions and other notifcations like pending invites or message updates. It's a pretty standard implementation for most applications and the Notifications page in our application is no different. To access the page, you must simply click on the bell icon in the navbar. Within this page, you can interact with notifications by clearing individual or all notifications by clicking `Clear All` or the `X`, respectively. 

As with the industry standard style of notifications, you should be able to to click on either the notification cards or the buttons to be directed to the relevant page that spawned the notification. In the case of the application currently, for the `Scheduling Request` notification, you should be able to click `See Availability` to be directed to the respective parties scheduling page.
