# Mitosis Simulation Final Report
**Team number:** 6 - UnitedInUnity

**Team members:**
- Ethan Hicks
- Rachel Reed 
- Forrest Sable 

## Introduction
Our project is an interactive cellular mitosis simulator designed in the game engine, Unity. Essentially, we have made a three-dimensional model of a simple cell that goes through the process of cellular mitosis. Our simulation is accessible through the Main Menu, where the user may select different settings and preferences for the game, such as the resolution of the screen they will be playing on, the graphics quality, and even the level of sound. Upon clicking “Start Simulation,” the user of our project can interact with different parts of the cell and receive information about what is going on, learning more in–depth about the aspects they so choose. The user is also able to click “Next” or “Back” buttons, allowing them the ease of exploring cellular mitosis at their own pace.
Our motivation for the mitosis simulator stems from the lack of in-depth and interactive scientific materials available to middle and high schoolers. During a lecture, teachers are unable to go into great detail due to time constraints, and while YouTube videos are great for overviews, you can’t learn more about each organelle at every stage of the mitosis process, and you can’t interact with the videos. Our proposed solution allows students to not only step through the process of mitosis at their own pace and witness the movement of organelles within the cell, but also to click on different organelles during the process to investigate what each organelle is doing.
Our approach is a simple one: we created a finite state machine to handle the transition between the different phases of mitosis. Each state of mitosis was coupled with animations of simple shaped organelles and different text boxes that were accessible only during this state. When each state is activated, an overview text box describes the current stage; different organelles can be clicked during each stage to uncover what is going on in each state. 
There were no major changes made to the requirements, design, or development plans. Our results yielded a successful mitosis simulation that offered insight on this complete cellular process. Our projects goals were met and allowed for our team to formulate the next steps of our project going forward. We concluded that for our product to truly be marketable, we would want to add in some enhancements like music and text-to-speech for ease of access for users.

## Customer Value
No changes in customer value since the project proposal.

## Technology
After completing our minimum viable project, we turned our attention on enhancing the amount of information presented to the user as well as animating the transitions between different cell stages. As for testing, our team ran through the entire simulation on a variety of laptops and desktops with different screen resolutions and graphics capabilities to ensure the portability of our simulation. Though our simulation ran excellent on computers, we struggled with sizing our program to the projector screen during our in-class demo, which will be further discussed in the reflection section of this report.

## Team
Our team roles have not changed that much throughout the entire project. Ethan oversaw the creation of a finite state machine and menu, and implementation of the detailed text boxes. Rachel created the text for the game interactions and cell stages, was responsible for all team reports and presentations. Forrest was in charge of the creation of organelles and animation of cell stages. Each of our team members were involved extensively in the last two weeks regarding debugging the program and each member presented equally during the in-class demo. All our members contributed a fair and equal amount to the project. The roles of our team members were static throughout the project.

## Project Management
Our team did complete all of our goals for this project. Below is a breakdown of our sprints: <br>
**Sprint #1**
- Create a finite state machine
- Model organelles
- Create text for describing cell process <br>

**Sprint #2**
- Model different mitosis stages
- Create main menu
- Implement text boxes <br>

**Sprint #3**
-	Implement interactive clicking of organelles
-	Start animations <br>

**Final Sprint**
-	Fix text box bug
-	Finish final animations
-	Create project presentation and final report

However, after completing all of our team’s goals, we uncovered several tasks that need to be accomplished for our project to be feasibly used in the academic world. These tasks are:

-	Add music to the simulation
-	Implement more biology scenarios
-	Add a “text-to-talk” option for interactions
-	Improve the graphics

## Reflection
For this iteration of the project, many things went well. Our team worked well together, all our tasks were completed, we were able to efficiently debug our program before our demo. Unfortunately, we encountered one obstacle during our demo: the screen size of the projector screen is not a standard screen size, and thus was not a selectable option on our Options Menu. During the presentation, the demo went off screen as the program tried to unsuccessfully fit itself to the odd screen size. In the future, we would want to add in a way for the program to automatically determine the screen size it was on without user input and size itself accordingly. Besides this small setback, we consider our project a success because we met all our milestones in a timely manner, worked well as a team, ad delivered the finished product in a timely manner.
