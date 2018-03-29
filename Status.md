Mitosis In Unity – Status Report
Team 6: UnitedInUnity 
Team Members: Ethan Hicks, Forrest Sable, Rachel Offutt-Reed

I. Introduction

Throughout the semester, our team has accomplished a great amount both together and individually. All the cellular organelles 
have been designed in both Unity and in Blender; the various organelles include the mitotic spindle, the centrosomes, the nucleolus,
the chromosomes inside the nucleolus, and the cell body. In addition to creating the organelles, we have created a game menu to ensure
the ease of use which comes equipped with a “play” button to run the simulation, an “options” button for sound settings, and an “end” 
button that exits the simulation. Once the play button has been clicked, the simulation runs, and text is displayed to describe the
animations and interactions happening on the screen. 
So far, our design requirements and goals for this project haven’t changed for the most part. The only initial goal for the project 
that had to be eliminated due time constraints is the addition of plant cellular mitosis. If we choose to continue building this 
project after the semester has ended, we will include cellular mitosis for plants and adapt the menu screen to allow selection 
between the different simulations. We only have one other minor change to our project: due to the complexity of animating the mitotic
spindle moving to encompass the entire area within the cell, we have decided that for simplicity’s sake and time constraints, the 
mitotic spindle will appear in its final resting location between prophase and prometaphase. This reduction of animation saves the
team countless hours of developing pathfinder code and keeping the animations looking professional and clean. We do, however, plan
on finishing the animation for the rest of the cellular stages.

II. Customer Value

There have been no changes since the project proposal. However, we have really had validation of the usefulness of our project that 
seems appropriate to mention. One of our members met by chance an educator in Washington, DC currently working on amassing grants for 
educational video games in the subject area of biology for educating students. Thus, there is a real, current need and value for
educational biology-based simulators and games.

III. Technology

Architecture: Components and their relationships
The architecture of our program is quite simple; there are two “scenes,” one for the menu and one for the simulation. The scripts 
that correlate with menu interactions are linked to the menu and the scripts that control the simulation are linked to that scene. 
The changing of mitosis stages and text describing these phases is handled by a switch statement. 

Goals for this iteration
Our goals for this iteration were to develop an animated simulation of cellular mitosis with overview descriptions of what was
happening during each stage of the mitosis process. So far, we have completed the goals of developing overview text to describe
each stage of mitosis, we have created the different cellular organelles in Blender, and we have created the menu and scene changes 
in the game engine Unity. We originally had planned to be finished with the animations completely by this point, but that step will 
be moved to the next iteration and done by the final demo, as it is not strictly necessary for the minimum viable product. 

What Works
So far, our entire simulation works. We have had no problems running into bugs and errors; our main constraint is time and 
complexity of animations. In this directory are screenshots of our main menu page, as well as a screenshot of one of our cellular stages, 
prophase, title 'mainSreenshot.png' and 'prophaseScreenshot.png', respectivley.

Tests Run
Since our project is essentially a game, the easiest way for us to test our project is to compile the game into an executable and 
run the game. So far, we run the game after each new addition or change has been made, in order to assure that the addition is not 
only working properly but hasn’t caused problems with other scripts and scenes in the game.

Goals for next iteration
Our goals for the final iteration are as follows: we will animate the transitions so that the moving of all the organelles between 
stages can be visualized. We also are implementing a way to click on each organelle during the different stages of the cellular mitosis
process so that the user can investigate what is going on with each specific organelle in more depth than the overview text for each 
stage. 

IV. Team 

During this iteration, our team roles have not differed much since the original proposal. Forrest predominantly handled the
animations of the organelles, Ethan handled the state change machine for changing between cell phases, and Rachel handled designing 
of some organelles and the text for the simulation. During the next iteration, Ethan will be responsible for writing the script to 
allow the clicking of each different organelle in the cell during each stage of mitosis, Rachel will set up the descriptions for each 
of the organelles in the different phases, and Forrest will finish making the organelles have smooth transitions between cellular 
stages.  

V. Project Management 

This project is currently slightly behind schedule. Currently, we have the simulation complete except for the clicking of the
organelles in each individual stage for additional information and smooth transitions between different stages. We plan on completing 
these tedious steps after the MVP demo, as it is not necessarily needed for a mitosis simulation but would be desired in the final 
product. Overall, all of our initial time requirements have been met, with the exception of the clicking of the organelles and clean
transitions. However, this will be completed by the end of the semester.

VI. Reflection 

Many things went well during this phase of our project development. The creation of the organelles went by smoothly, as Forrest has 
extensive experience using Blender. The finite state machine for switching scenes and therefore transitioning between cell stages
works perfectly, and the interaction text was easy to write. Unfortunately, our team experienced some hiccups along the way. For one,
we discovered that even in Github, when two people edit the same file and both push, the file will be rendered permanently unusable
and Github will have to be reverted to a previous commit. This error is caused by the “>>>>>HEAD” comments that Github puts directly
into the Unity file when merging two versions. Unity itself cannot read the file once these comments are put in, resulting in the 
files being unusable and the changes being lost; we lot a good deal of progress this way, and initially, it was a struggle and 
annoyance to catch back up to speed. Another challenge our team had was the using of Github for issue tracking. Since we have
multiple classes together, we would just discuss our next plans and show each other our progress via our own local versions, 
instead of pushing and reviewing. During our next iteration, we plan on cataloguing our progress much better and documenting our 
repository better so that others wishing to use and modify this project can understand our reasoning behind our choices in code and 
how each script works.

