# Habit Tracker Project!#

## Overview
The Habit Tracker Project is a simple and effective way to monitor and maintain your daily habits.
This program was made using C# in Windows Forms with a user-friendly interface.
This program includes two unit tests, SOLID principles, and an experimental branch.

## Features
- Add, edit, and delete habits
- Mark habits as completed for the day
- View progress over time with simple statistics
- User-friendly interface
- Unit tests to ensure reliability
- Adheres to SOLID principles for maintainable code
- Experimental branch for testing new features


## File Structure
HabitTrackerApp/
├──Controllers/
├──Views/AddHabitForm.cs, MainForm.cs

HabitTrackerCore/
├──Interfaces/
├──Models/Habit.cs
├──Services/HabitService.cs
├──Models/

HabitTrackerTests/
├──UnitTest1.cs

## Installation Instructions
1. Clone the repository from GitHub.
2. Open the solution file in Visual Studio.
3. Restore NuGet packages if necessary.
4. Build the solution.
5. Run the HabitTrackerApp project.
6. Enjoy tracking your habits!

## API Usage details
The Habit Tracker Project does not currently utilize any external APIs. All functionality is handled locally within the application.


## How Data Is Stored
Data is stored in-memory during the application's runtime. No external database or file storage is currently implemented.


## Known Issues/Limitations
Data is not persisted between user sessions. 


## Debugging Summary
- Errors when no habit was selected.
- Buttons not responding due to event handlers not being properly assigned.
- UI elements not updating after data changes.

## Credits and Acknowledgments
Project created by Sannah Penelope Mutanga 
	




	